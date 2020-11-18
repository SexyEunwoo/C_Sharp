namespace Car_Controller
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lab_Speed = new System.Windows.Forms.Label();
            this.lab_CurSpeed = new System.Windows.Forms.Label();
            this.lab_Left = new System.Windows.Forms.Label();
            this.lab_IsLeft = new System.Windows.Forms.Label();
            this.lab_Right = new System.Windows.Forms.Label();
            this.lab_IsRight = new System.Windows.Forms.Label();
            this.Control_Timer = new System.Windows.Forms.Timer(this.components);
            this.combo_SerialList = new System.Windows.Forms.ComboBox();
            this.groupBox_SerialConnector = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.but_Connect = new System.Windows.Forms.Button();
            this.lab_IsConnected = new System.Windows.Forms.Label();
            this.lab_BaudRate = new System.Windows.Forms.Label();
            this.combo_BaudRate = new System.Windows.Forms.ComboBox();
            this.lab_SerialPort = new System.Windows.Forms.Label();
            this.groupBox_SerialConnector.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_Speed
            // 
            this.lab_Speed.AutoSize = true;
            this.lab_Speed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lab_Speed.ForeColor = System.Drawing.Color.White;
            this.lab_Speed.Location = new System.Drawing.Point(417, 67);
            this.lab_Speed.Name = "lab_Speed";
            this.lab_Speed.Size = new System.Drawing.Size(52, 15);
            this.lab_Speed.TabIndex = 0;
            this.lab_Speed.Text = "스피드";
            // 
            // lab_CurSpeed
            // 
            this.lab_CurSpeed.AutoSize = true;
            this.lab_CurSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lab_CurSpeed.ForeColor = System.Drawing.Color.White;
            this.lab_CurSpeed.Location = new System.Drawing.Point(548, 67);
            this.lab_CurSpeed.Name = "lab_CurSpeed";
            this.lab_CurSpeed.Size = new System.Drawing.Size(15, 15);
            this.lab_CurSpeed.TabIndex = 1;
            this.lab_CurSpeed.Text = "0";
            // 
            // lab_Left
            // 
            this.lab_Left.AutoSize = true;
            this.lab_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lab_Left.ForeColor = System.Drawing.Color.White;
            this.lab_Left.Location = new System.Drawing.Point(417, 126);
            this.lab_Left.Name = "lab_Left";
            this.lab_Left.Size = new System.Drawing.Size(72, 15);
            this.lab_Left.TabIndex = 2;
            this.lab_Left.Text = "왼쪽 눌림";
            // 
            // lab_IsLeft
            // 
            this.lab_IsLeft.AutoSize = true;
            this.lab_IsLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lab_IsLeft.ForeColor = System.Drawing.Color.White;
            this.lab_IsLeft.Location = new System.Drawing.Point(548, 126);
            this.lab_IsLeft.Name = "lab_IsLeft";
            this.lab_IsLeft.Size = new System.Drawing.Size(42, 15);
            this.lab_IsLeft.TabIndex = 3;
            this.lab_IsLeft.Text = "False";
            // 
            // lab_Right
            // 
            this.lab_Right.AutoSize = true;
            this.lab_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lab_Right.ForeColor = System.Drawing.Color.White;
            this.lab_Right.Location = new System.Drawing.Point(417, 178);
            this.lab_Right.Name = "lab_Right";
            this.lab_Right.Size = new System.Drawing.Size(87, 15);
            this.lab_Right.TabIndex = 4;
            this.lab_Right.Text = "오른쪽 눌림";
            // 
            // lab_IsRight
            // 
            this.lab_IsRight.AutoSize = true;
            this.lab_IsRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lab_IsRight.ForeColor = System.Drawing.Color.White;
            this.lab_IsRight.Location = new System.Drawing.Point(548, 178);
            this.lab_IsRight.Name = "lab_IsRight";
            this.lab_IsRight.Size = new System.Drawing.Size(42, 15);
            this.lab_IsRight.TabIndex = 5;
            this.lab_IsRight.Text = "False";
            // 
            // Control_Timer
            // 
            this.Control_Timer.Enabled = true;
            this.Control_Timer.Interval = 50;
            this.Control_Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // combo_SerialList
            // 
            this.combo_SerialList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.combo_SerialList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_SerialList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_SerialList.ForeColor = System.Drawing.Color.White;
            this.combo_SerialList.FormattingEnabled = true;
            this.combo_SerialList.Location = new System.Drawing.Point(123, 42);
            this.combo_SerialList.Name = "combo_SerialList";
            this.combo_SerialList.Size = new System.Drawing.Size(121, 23);
            this.combo_SerialList.TabIndex = 6;
            this.combo_SerialList.TabStop = false;
            // 
            // groupBox_SerialConnector
            // 
            this.groupBox_SerialConnector.Controls.Add(this.button1);
            this.groupBox_SerialConnector.Controls.Add(this.but_Connect);
            this.groupBox_SerialConnector.Controls.Add(this.lab_IsConnected);
            this.groupBox_SerialConnector.Controls.Add(this.lab_BaudRate);
            this.groupBox_SerialConnector.Controls.Add(this.combo_BaudRate);
            this.groupBox_SerialConnector.Controls.Add(this.lab_SerialPort);
            this.groupBox_SerialConnector.Controls.Add(this.combo_SerialList);
            this.groupBox_SerialConnector.ForeColor = System.Drawing.Color.White;
            this.groupBox_SerialConnector.Location = new System.Drawing.Point(12, 12);
            this.groupBox_SerialConnector.Name = "groupBox_SerialConnector";
            this.groupBox_SerialConnector.Size = new System.Drawing.Size(301, 231);
            this.groupBox_SerialConnector.TabIndex = 7;
            this.groupBox_SerialConnector.TabStop = false;
            this.groupBox_SerialConnector.Text = "SerialConnector";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(154, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "포트검색";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // but_Connect
            // 
            this.but_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Connect.Location = new System.Drawing.Point(38, 147);
            this.but_Connect.Name = "but_Connect";
            this.but_Connect.Size = new System.Drawing.Size(88, 28);
            this.but_Connect.TabIndex = 11;
            this.but_Connect.Text = "연결";
            this.but_Connect.UseVisualStyleBackColor = true;
            this.but_Connect.Click += new System.EventHandler(this.but_Connect_Click);
            // 
            // lab_IsConnected
            // 
            this.lab_IsConnected.AutoSize = true;
            this.lab_IsConnected.Location = new System.Drawing.Point(96, 191);
            this.lab_IsConnected.Name = "lab_IsConnected";
            this.lab_IsConnected.Size = new System.Drawing.Size(97, 15);
            this.lab_IsConnected.TabIndex = 10;
            this.lab_IsConnected.Text = "Disconnected";
            // 
            // lab_BaudRate
            // 
            this.lab_BaudRate.AutoSize = true;
            this.lab_BaudRate.Location = new System.Drawing.Point(31, 101);
            this.lab_BaudRate.Name = "lab_BaudRate";
            this.lab_BaudRate.Size = new System.Drawing.Size(71, 15);
            this.lab_BaudRate.TabIndex = 9;
            this.lab_BaudRate.Text = "BaudRate";
            // 
            // combo_BaudRate
            // 
            this.combo_BaudRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.combo_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_BaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_BaudRate.ForeColor = System.Drawing.Color.White;
            this.combo_BaudRate.FormattingEnabled = true;
            this.combo_BaudRate.Location = new System.Drawing.Point(123, 98);
            this.combo_BaudRate.Name = "combo_BaudRate";
            this.combo_BaudRate.Size = new System.Drawing.Size(121, 23);
            this.combo_BaudRate.TabIndex = 8;
            this.combo_BaudRate.TabStop = false;
            // 
            // lab_SerialPort
            // 
            this.lab_SerialPort.AutoSize = true;
            this.lab_SerialPort.Location = new System.Drawing.Point(31, 45);
            this.lab_SerialPort.Name = "lab_SerialPort";
            this.lab_SerialPort.Size = new System.Drawing.Size(70, 15);
            this.lab_SerialPort.TabIndex = 7;
            this.lab_SerialPort.Text = "SerialPort";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_SerialConnector);
            this.Controls.Add(this.lab_IsRight);
            this.Controls.Add(this.lab_Right);
            this.Controls.Add(this.lab_IsLeft);
            this.Controls.Add(this.lab_Left);
            this.Controls.Add(this.lab_CurSpeed);
            this.Controls.Add(this.lab_Speed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox_SerialConnector.ResumeLayout(false);
            this.groupBox_SerialConnector.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Speed;
        private System.Windows.Forms.Label lab_CurSpeed;
        private System.Windows.Forms.Label lab_Left;
        private System.Windows.Forms.Label lab_IsLeft;
        private System.Windows.Forms.Label lab_Right;
        private System.Windows.Forms.Label lab_IsRight;
        private System.Windows.Forms.Timer Control_Timer;
        private System.Windows.Forms.ComboBox combo_SerialList;
        private System.Windows.Forms.GroupBox groupBox_SerialConnector;
        private System.Windows.Forms.Label lab_IsConnected;
        private System.Windows.Forms.Label lab_BaudRate;
        private System.Windows.Forms.ComboBox combo_BaudRate;
        private System.Windows.Forms.Label lab_SerialPort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button but_Connect;
    }
}

