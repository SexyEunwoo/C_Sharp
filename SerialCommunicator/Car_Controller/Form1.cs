using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Controller
{
    public partial class Form1 : Form
    {
        private int speed;
        private int speed_weight;
        private bool go_front;
        private bool go_back;
        private bool go_left;
        private bool go_right;
        private bool esc;
        private SerialPort sp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sp = new SerialPort();
            this.combo_SerialList.DataSource = SerialPort.GetPortNames();
            this.combo_SerialList.SelectedIndex = 0;
            this.combo_BaudRate.Items.Add(9600); this.combo_BaudRate.Items.Add(115200);
            this.combo_BaudRate.SelectedIndex = 0;

            this.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.W) && (this.go_front == false)) { this.go_front = true; this.speed_weight = 1; }
            if ((e.KeyCode) == Keys.S && (this.go_back == false)) { this.go_back = true; this.speed_weight = -1; }
            if (e.KeyCode == Keys.A) { this.go_left = true; }
            if (e.KeyCode == Keys.D) { this.go_right = true; }
            if (e.KeyCode == Keys.Escape) { this.esc = true; }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { this.go_front = false; this.speed_weight = 0; }
            if (e.KeyCode == Keys.S) { this.go_back = false;  this.speed_weight = 0; }
            if (e.KeyCode == Keys.A) { this.go_left = false; }
            if (e.KeyCode == Keys.D) { this.go_right = false; }
            if (e.KeyCode == Keys.Escape) { this.esc = false; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.esc) { this.groupBox_SerialConnector.Visible = true; }

            // 전진 후진 관리
            if(this.speed == 0) // 정지해 있다면
            {
                if(this.go_front) { this.speed += speed_weight++; }
                else if(this.go_back) { this.speed -= speed_weight--; }
            }
            else if(this.speed > 0 && this.speed <= 127) // 전진중이라면
            {
                if(this.go_front) { this.speed += speed_weight++; }
                else if(this.go_back) { this.speed += speed_weight--; }
                else { this.speed--; }
            }
            else if(this.speed < 0 && this.speed >= -128) // 후진중이라면
            {
                if (this.go_front) { this.speed += speed_weight++; }
                else if (this.go_back) { this.speed += speed_weight--; }
                else { this.speed++; }
            }

            // 방향관리
            if (this.go_left) { lab_IsLeft.Text = "True"; }
            else { this.lab_IsLeft.Text = "False"; }
            if (this.go_right) { lab_IsRight.Text = "True"; }
            else { this.lab_IsRight.Text = "False"; }

            if(this.speed > 127) { this.speed = 127; }
            if(this.speed < -128) { this.speed = -128; }
            
            
            if (this.sp.IsOpen)
            {
                if(this.go_front)
                {
                    this.sp.Write("F");
                }
                else if(this.go_back) { this.sp.Write("B"); }
                else if (this.go_left) { this.sp.Write("L"); }
                else if (this.go_right) { this.sp.Write("R"); }
                else { this.sp.Write("S"); }

            }

            this.lab_CurSpeed.Text = Convert.ToString(this.speed);
        }

        private void but_Connect_Click(object sender, EventArgs e)
        {
            if (this.sp.IsOpen == false)
            {
                string com = this.combo_SerialList.SelectedItem?.ToString();
                string baudRate = this.combo_BaudRate.SelectedItem?.ToString();

                if (com == "null" || baudRate == "null")
                    return;

                this.sp.PortName = com;
                this.sp.BaudRate = Int32.Parse(baudRate);
                this.sp.DataBits = 8;
                this.sp.StopBits = StopBits.One;
                this.sp.Parity = Parity.None;
                this.sp.Open();

                this.but_Connect.Text = "연결끊기";
                this.lab_IsConnected.Text = "Connected";
                this.groupBox_SerialConnector.Visible = false;
            }
            else
            {
                this.sp.Close();

                this.but_Connect.Text = "연결";
                this.lab_IsConnected.Text = "Disconnected";
            }
            this.Focus();
        }
    }
}
