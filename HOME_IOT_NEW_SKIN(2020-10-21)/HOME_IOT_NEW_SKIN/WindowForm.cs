using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using M2Mqtt;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Configuration;

namespace HOME_IOT_NEW_SKIN
{
    public partial class menuForm : Form
    {
        #region Properties
        static public List<KeyValuePair<string, string>> codes;   // Key, Value페어를 이용해 "회사명-종목코드" 연결고리 생성
        private const int weatherDays = 2; // weather에 저장할 날짜의 개수( 2일의 데이터 저장 )
        private const int weatherTimes = 3; // weather에 저장할 시간대의 개수 ( 3개의 시간대 저장 )
        private Weather[,] weather;

        private MqttClient client;

        private Form curForm;
        #endregion

        #region Init&Close Form
        public menuForm()
        {
            InitializeComponent();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {
            // 기본 서브메뉴 숨기기
            HideSubMenu();

            // 날씨 관련 데이터 셋업
            SetWeatherDateLabel();
            weather = new Weather[weatherDays, weatherTimes];
            for (int i = 0; i < weatherDays; i++)
                for (int j = 0; j < weatherTimes; j++)
                    weather[i, j] = new Weather();

            // MQTT 설정
            client = new MqttClient("localhost");
            client.Connect("Home-PC");

            // 전체화면 설정
            // this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            // this.WindowState = FormWindowState.Maximized;

            // 주식종목 코드리스트 가져오기
            StockCodeUpdate();
        }

        private void menuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 타이머 전부 할당 해제
            this.MqttTimer.Stop();
            this.MqttTimer.Dispose();
            this.weatherTimer.Stop();
            this.weatherTimer.Dispose();

            // MQTT 연결 해제
            client.Disconnect();

        }
    #endregion

        #region Menu
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false) // 메뉴가 보이지 않는다면
            {
                HideSubMenu();
                subMenu.Visible = true; // 메뉴가 보이게 설정
            }
            else
            {
                HideSubMenu();
            }
        }

        private void HideSubMenu()
        {
            panelStockSubMenu.Visible = false;
        }
        #endregion

        #region ClickEvent
        private void butStock_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelStockSubMenu);
        }

        private void butStockDay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StockDayForm());
            HideSubMenu();
        }

        private void butStockWeek_Click(object sender, EventArgs e)
        {
            /*
                Code
            */
            HideSubMenu();
        }

        private void butStockMonth_Click(object sender, EventArgs e)
        {
            /*
                Code
            */
            HideSubMenu();
        }

        private void butStockTotal_Click(object sender, EventArgs e)
        {
            /*
                Code
            */
            HideSubMenu();
        }

        private void ledPower_Click(object sender, EventArgs e)
        {
            /*
                Code
            */
            HideSubMenu();
        }

        private void pcPower_Click(object sender, EventArgs e)
        {
            this.client.Publish("POWER", new byte[] { 1 });
            HideSubMenu();
        }

        private void butMain_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainForm());
            HideSubMenu();
        }
        #endregion

        #region Timer
        private void weatherTimer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            using (StreamReader sr = new StreamReader(new FileStream("weather.log", FileMode.OpenOrCreate, FileAccess.Read)))
            {
                string str = sr.ReadLine();

                if (str != null)
                {
                    if (str.CompareTo(now.Month.ToString() + "." + now.Day.ToString()) == 0) // 이미 날씨정보를 받아 왔다면
                        return;
                }
            }

            if (now.Hour != 3) // 새벽 3시가 아니라면
            {
                return;
            }
            else // 새벽 3시라면
            {
                try
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load("http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4127357000");

                    // channel/item/description/body/data의 하위 노드들을 가져온다
                    XmlNodeList nodes = xmlDocument.DocumentElement.SelectNodes("channel/item/description/body/data");

                    foreach (XmlNode node in nodes)
                    {
                        if (node["day"].InnerText.Equals("0")) // 당일 기상예보이면서
                        {
                            switch (node["hour"].InnerText)
                            {
                                case "9":
                                    weather[0, 0].Date = node["day"].InnerText;
                                    weather[0, 0].WeatherStatus = node["wfEn"].InnerText;
                                    break;
                                case "12":
                                    weather[0, 1].Date = node["day"].InnerText;
                                    weather[0, 1].WeatherStatus = node["wfEn"].InnerText;
                                    break;
                                case "18":
                                    weather[0, 2].Date = node["day"].InnerText;
                                    weather[0, 2].WeatherStatus = node["wfEn"].InnerText;
                                    break;
                            }
                        }
                        else if (node["day"].InnerText.Equals("1")) // 다음날 기상예보이면서
                        {
                            switch (node["hour"].InnerText)
                            {
                                case "9":
                                    weather[1, 0].Date = node["day"].InnerText;
                                    weather[1, 0].WeatherStatus = node["wfEn"].InnerText;
                                    break;
                                case "12":
                                    weather[1, 1].Date = node["day"].InnerText;
                                    weather[1, 1].WeatherStatus = node["wfEn"].InnerText;
                                    break;
                                case "18":
                                    weather[1, 2].Date = node["day"].InnerText;
                                    weather[1, 2].WeatherStatus = node["wfEn"].InnerText;
                                    break;
                            }
                        }
                    }

                    imgToday9AM.Image = WeatherToImage(weather[0, 0].WeatherStatus);
                    imgToday12PM.Image = WeatherToImage(weather[0, 1].WeatherStatus);
                    imgToday18PM.Image = WeatherToImage(weather[0, 2].WeatherStatus);
                    imgTomorrow9AM.Image = WeatherToImage(weather[1, 0].WeatherStatus);
                    imgTomorrow12PM.Image = WeatherToImage(weather[1, 1].WeatherStatus);
                    imgTomorrow18PM.Image = WeatherToImage(weather[1, 2].WeatherStatus);

                    using (StreamWriter sw = new StreamWriter(new FileStream("weather.log", FileMode.Append, FileAccess.Write)))
                    {
                        string successStr = string.Format("{0}.{1}", now.Month, now.Day);
                        sw.WriteLine(successStr);
                    }
                }
                catch (Exception ex)
                {
                    using (StreamWriter sw = new StreamWriter(new FileStream("error.log", FileMode.Append, FileAccess.Write)))
                    {
                        string errStr = string.Format("{0} : {1}", now.ToString(), ex.Message);
                        sw.WriteLine(errStr);
                    }
                }
            }
        }
        private void MqttTimer_Tick(object sender, EventArgs e)
        {
            if (!client.IsConnected) // 연결이 끊겼다면
                client.Connect("HOME-PC");
        }
        #endregion

        #region WeatherFunction
        private Bitmap WeatherToImage(string weather)
        {
            switch (weather)
            {
                case "Clear":
                    return Properties.Resources.Sunny;
                case "Mostly Cloudy":
                    return Properties.Resources.MostlyColudy;
                case "Cloudy":
                    return Properties.Resources.Coludy;
                case "Rain":
                    return Properties.Resources.Rainy;
                case "Snow":
                    return Properties.Resources.Snow;
                default:
                    return null;
            }
        }

        private void SetWeatherDateLabel()
        {
            DateTime now = DateTime.Now;
            this.labToday9AM.Text = string.Format("{0}.{1} 9AM", now.Month, now.Day);
            this.labToday12PM.Text = string.Format("{0}.{1} 12PM", now.Month, now.Day);
            this.labToday18PM.Text = string.Format("{0}.{1} 18PM", now.Month, now.Day);

            DateTime tomorrow = now.AddDays(1);
            this.labTomorrow9AM.Text = string.Format("{0}.{1} 9AM", tomorrow.Month, tomorrow.Day);
            this.labTomorrow12PM.Text = string.Format("{0}.{1} 12PM", tomorrow.Month, tomorrow.Day);
            this.labTomorrow18PM.Text = string.Format("{0}.{1} 18PM", tomorrow.Month, tomorrow.Day);
        }
        #endregion

        #region StockInitFunction
        private void StockCodeUpdate()
        {
            // 파일 존재 여부 확인
            string curPath = string.Format("{0}\\stockCode.log", System.Environment.CurrentDirectory);
            if (File.Exists(curPath))
            {
                //첫 번째 줄엔 날짜가 적혀있다
                string[] strsFile = File.ReadAllLines(curPath);
                MessageBox.Show(strsFile[0] + ".Ver");


                // 두 번째 줄부터 회사명:코드 값을 읽어와서 저장한다.
                codes = new List<KeyValuePair<string, string>>();
                for (int i = 1; i < strsFile.Length; i++)
                {
                    string[] name_code = strsFile[i].Split(':');
                    codes.Add(new KeyValuePair<string, string>(name_code[0], name_code[1]));
                }

                MessageBox.Show("Loading Finished!");
            }
            else // 파일이 없다면
            {
                MessageBox.Show("There is no saved file... Please wait for extracting data...");
                string path = string.Format("{0}\\code.xls", System.Environment.CurrentDirectory);
                Excel.Application excelApp = null;
                Excel.Workbook wb = null;
                Excel.Worksheet ws = null;
                codes = new List<KeyValuePair<string, string>>();

                try
                {
                    excelApp = new Excel.Application();
                    wb = excelApp.Workbooks.Open(path);
                    ws = wb.Sheets[1];

                    excelApp.Visible = false;
                    Range range = ws.UsedRange;

                    for (int i = 2; i < range.Rows.Count; i++)
                    {
                        string name = (range.Cells[i, 1] as Range).Value2.ToString();
                        string code = (range.Cells[i, 2] as Range).Value2.ToString();
                        codes.Add(new KeyValuePair<string, string>(name, code));
                    }
                    ReleaseExcelObject(ws);
                    ReleaseExcelObject(wb);
                    ReleaseExcelObject(excelApp);

                    // stockCode.log 파일 쓰기
                    using(StreamWriter sw = new StreamWriter(new FileStream(curPath, FileMode.Create, FileAccess.Write)))
                    {
                        sw.WriteLine(DateTime.Now.ToString());
                        for(int i = 0; i < codes.Count; i++)
                        {
                            // 회사이름:코드 쓰기
                            sw.WriteLine(string.Format("{0}:{1}", codes[i].Key, codes[i].Value));
                        }
                        File.SetAttributes(curPath, FileAttributes.Hidden);
                    }
                    MessageBox.Show("Loading Finished!");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Loading Error! Please check Load.log");

                    using (StreamWriter sw = new StreamWriter(new FileStream("_ProgramLoadError.log", FileMode.Append, FileAccess.Write)))
                    {
                        string errorStr = string.Format("{0} : {1}", DateTime.Now.ToString(), error.Message);
                        sw.WriteLine(errorStr);
                        sw.Close();
                    }
                    this.Close();
                }
                finally
                {
                    ReleaseExcelObject(ws);
                    ReleaseExcelObject(wb);
                    ReleaseExcelObject(excelApp);
                }
            }
        }
        
        private void ReleaseExcelObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch(Exception e)
            {
                obj = null;
                throw e;
            }
            finally
            {
                GC.Collect();
            }
        }
        #endregion

        #region ETC
        private string GetTimeString()
        {
            DateTime now = DateTime.Now;
            string ret;

            ret = now.Year.ToString() + "-";
            ret += ((now.Month < 10) ? ("0" + now.Month.ToString()) : (now.Month.ToString())) + "-";
            ret += ((now.Day < 10) ? ("0" + now.Day.ToString()) : (now.Day.ToString())) + " ";
            ret += ((now.Hour < 10) ? ("0" + now.Hour.ToString()) : (now.Hour.ToString())) + ":";
            ret += ((now.Minute < 10) ? ("0" + now.Minute.ToString()) : (now.Minute.ToString())) + ":";
            ret += (now.Second < 10) ? ("0" + now.Second.ToString()) : (now.Second.ToString());

            return ret;
        }

        private void OpenChildForm(Form childForm)
        {
            if (curForm != null)
                curForm.Close();

            curForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDisplay.Controls.Add(childForm);
            panelDisplay.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion
    }
}
