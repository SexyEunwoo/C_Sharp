using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HOME_IOT_NEW_SKIN
{
    public partial class StockDayForm : Form
    {
        public static Stock[] stockTodayPrice;
        public static bool isInit;
        public static Timer[] timers;

        public StockDayForm()
        {
            InitializeComponent();
        }

        private void StockDayForm_Load(object sender, EventArgs e)
        {
            if (!isInit)
            {
                stockTodayPrice = new Stock[4] { new Stock(), new Stock(), new Stock(), new Stock() };
                timers = new Timer[4] { timerFirstStock, timerSecondStock, timerThirdStock, timerFourthStock };
                isInit = true;
            }
        }

        private void butAddEvent_Click(object sender, EventArgs e)
        {
            int idx = CheckStockStorage();

            if(idx == -1)
            {
                MessageBox.Show("종목이 꽉찼습니다.");
                return;
            }

            StockAddForm addForm = new StockAddForm();
            addForm.TopLevel = true;
            addForm.Activate();
            addForm.StartPosition = FormStartPosition.CenterParent;
            addForm.ShowDialog();

            if(addForm.DialogResult == DialogResult.OK)
                stockTodayPrice[idx].Initialize(addForm.name, addForm.code, addForm.count, addForm.price);

            addForm.Close();
            timers[idx].Enabled = true;
            return;
        }

        private void butBuyStock_Click(object sender, EventArgs e)
        {
            StockBuyForm buyForm = new StockBuyForm();
            buyForm.TopLevel = true;
            buyForm.Activate();
            buyForm.StartPosition = FormStartPosition.CenterParent;
            buyForm.ShowDialog();

            if(buyForm.DialogResult == DialogResult.OK)
            {
                stockTodayPrice[buyForm.idx].BuyStock(buyForm.cnt, buyForm.price);
            }

            buyForm.Close();
            return;
        }

        private void butSellStock_Click(object sender, EventArgs e)
        {

        }

        private void butDel_Click(object sender, EventArgs e)
        {

        }

        private int CheckStockStorage()
        {
            for (int i = 0; i < 4; i++)
            {
                if (!stockTodayPrice[i].Isinit)
                {
                    return i;
                }
            }

            return -1;
        }

        private bool SetFluctuationColor(System.Windows.Forms.Label lab, int fluc)
        {
            if (fluc >= 0)
            {
                lab.ForeColor = Color.Red;
                return true;
            }
            else
            {
                lab.ForeColor = Color.DeepSkyBlue;
                return false;
            }
        }

        private bool SetFluctuationColor(System.Windows.Forms.Label lab, double fluc)
        {
            if (fluc >= 0)
            {
                lab.ForeColor = Color.Red;
                return true;
            }
            else
            {
                lab.ForeColor = Color.DeepSkyBlue;
                return false;
            }
        }

        private void timerFirstStock_Tick(object sender, EventArgs e)
        {
            if (stockTodayPrice[0].Isinit)
            {
                try
                {
                    string xmlLink = string.Format(@"https://fchart.stock.naver.com/sise.nhn?symbol={0}&timeframe=day&count=1500&requestType=0", stockTodayPrice[0].Code);
                    XmlDocument stockDoc = new XmlDocument();
                    stockDoc.Load(xmlLink);

                    XmlNodeList chartDataList = stockDoc.SelectNodes("protocol/chartdata");
                    XmlNode chartData = chartDataList[0];
                    XmlNode todayNode = chartData.LastChild;
                    string xmlStr = todayNode.OuterXml;

                    if (!stockTodayPrice[0].Update(xmlStr))
                        this.Enabled = false;

                    // Visible 설정
                    this.labFirstStockName.Visible = true;
                    this.labFirstStockCurPriceName.Visible = true;
                    this.labFirstStockBeforePriceName.Visible = true;
                    this.labFirstStockBenefitName.Visible = true;


                    // 주식 이름 설정
                    this.labFirstStockName.Text = stockTodayPrice[0].Name;

                    // 현재 가격 설정
                    this.labFirstStockCurPrice.Text = string.Format("{0:#,0}", stockTodayPrice[0].CurPrice);

                    // 현재 주가 상승수치, 상승률 설정
                    int fluctuation = stockTodayPrice[0].CurPrice - stockTodayPrice[0].EndPriceYesterday;
                    if (SetFluctuationColor(labFirstStockCurFluctuation, fluctuation))
                        this.labFirstStockCurFluctuation.Text = string.Format("▲{0:#,0}", fluctuation);
                    else
                        this.labFirstStockCurFluctuation.Text = string.Format("▼{0:#,0}", fluctuation);

                    double fluctuationRate = (double)stockTodayPrice[0].CurPrice / (double)stockTodayPrice[0].EndPriceYesterday;
                    fluctuationRate -= 1.0; fluctuationRate *= 100.0; fluctuationRate = Math.Round(fluctuationRate * 100) / 100;
                    SetFluctuationColor(labFirstStockCurFluctuationRate, fluctuationRate);
                    this.labFirstStockCurFluctuationRate.Text = string.Format("{0}%", fluctuationRate);

                    // 전일가 설정
                    this.labFirstStockBeforePrice.Text = string.Format("{0:#,0}", stockTodayPrice[0].EndPriceYesterday);

                    // 구매가 설정
                    this.labFirstStockBuyPriceName.Visible = true;
                    this.labFirstStockBuyPrice.Text = string.Format("{0:#,0}{1}{2}", stockTodayPrice[0].PurchasePrice, Environment.NewLine, stockTodayPrice[0].Count);

                    // 수익률 설정
                    this.labFirstStockBenefitFigure.Text = string.Format("{0:#,0}￦", stockTodayPrice[0].TotalCurPrice - stockTodayPrice[0].TotalPurPrice);
                }
                catch (Exception error)
                {
                    using (StreamWriter sw = new StreamWriter(new FileStream("_ProgramStockFormError.log", FileMode.Append, FileAccess.Write)))
                    {
                        MessageBox.Show("XmlError! Please check StockFormError.log");
                        string text = string.Format("{0} : {1}", DateTime.Now.ToString(), error.Message);

                        sw.WriteLine(text);
                    }
                }
            }
            else
            {
                // hide 및 값 초기화 하기
                timerFirstStock.Enabled = false;
            }
        }

        private void timerSecondStock_Tick(object sender, EventArgs e)
        {
            if (stockTodayPrice[1].Isinit)
            {
                try
                {
                    string xmlLink = string.Format(@"https://fchart.stock.naver.com/sise.nhn?symbol={0}&timeframe=day&count=1500&requestType=0", stockTodayPrice[1].Code);
                    XmlDocument stockDoc = new XmlDocument();
                    stockDoc.Load(xmlLink);

                    XmlNodeList chartDataList = stockDoc.SelectNodes("protocol/chartdata");
                    XmlNode chartData = chartDataList[0];
                    XmlNode todayNode = chartData.LastChild;
                    string xmlStr = todayNode.OuterXml;

                    if (!stockTodayPrice[1].Update(xmlStr))
                        this.Enabled = false;

                    // Visible 설정
                    this.labSecondStockName.Visible = true;
                    this.labSecondStockCurPriceName.Visible = true;
                    this.labSecondStockBeforePriceName.Visible = true;
                    this.labSecondStockBenefitName.Visible = true;


                    // 주식 이름 설정
                    this.labSecondStockName.Text = stockTodayPrice[1].Name;

                    // 현재 가격 설정
                    this.labSecondStockCurPrice.Text = string.Format("{0:#,0}", stockTodayPrice[1].CurPrice.ToString());

                    // 현재 주가 상승수치, 상승률 설정
                    int fluctuation = stockTodayPrice[1].CurPrice - stockTodayPrice[1].EndPriceYesterday;
                    if (SetFluctuationColor(labSecondStockCurFluctuation, fluctuation))
                        this.labSecondStockCurFluctuation.Text = string.Format("▲{0:#,0}", fluctuation);
                    else
                        this.labSecondStockCurFluctuation.Text = string.Format("▼{0:#,0}", fluctuation);

                    double fluctuationRate = (double)stockTodayPrice[1].CurPrice / (double)stockTodayPrice[1].EndPriceYesterday;
                    fluctuationRate -= 1.0; fluctuationRate *= 100.0; fluctuationRate = Math.Round(fluctuationRate * 100) / 100;
                    SetFluctuationColor(labSecondStockCurFluctuationRate, fluctuationRate);
                    this.labSecondStockCurFluctuationRate.Text = string.Format("{0}%", fluctuationRate);

                    // 전일가 설정
                    this.labSecondStockBeforePrice.Text = string.Format("{0:#,0}", stockTodayPrice[1].EndPriceYesterday);

                    // 구매가 설정
                    this.labSecondStockBuyPriceName.Visible = true;
                    this.labSecondStockBuyPrice.Text = string.Format("{0:#,0}", stockTodayPrice[1].PurchasePrice);

                    // 수익률 설정
                    this.labSecondStockBenefitFigure.Text = string.Format("{0:#,0}￦", stockTodayPrice[1].TotalCurPrice - stockTodayPrice[1].TotalPurPrice);
                }
                catch (Exception error)
                {
                    using (StreamWriter sw = new StreamWriter(new FileStream("_ProgramStockFormError.log", FileMode.Append, FileAccess.Write)))
                    {
                        MessageBox.Show("XmlError! Please check StockFormError.log");
                        string text = string.Format("{0} : {1}", DateTime.Now.ToString(), error.Message);

                        sw.WriteLine(text);
                    }
                }
            }
            else
            {
                timerSecondStock.Enabled = false;
            }
        }
    }
}
