namespace HOME_IOT_NEW_SKIN
{
    partial class menuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.butPcPower = new System.Windows.Forms.Button();
            this.butLedPower = new System.Windows.Forms.Button();
            this.panelStockSubMenu = new System.Windows.Forms.Panel();
            this.butStockTotal = new System.Windows.Forms.Button();
            this.butStockMonth = new System.Windows.Forms.Button();
            this.butStockWeek = new System.Windows.Forms.Button();
            this.butStockDay = new System.Windows.Forms.Button();
            this.butStock = new System.Windows.Forms.Button();
            this.butMain = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelWeather = new System.Windows.Forms.Panel();
            this.labTomorrow18PM = new System.Windows.Forms.Label();
            this.labTomorrow12PM = new System.Windows.Forms.Label();
            this.labTomorrow9AM = new System.Windows.Forms.Label();
            this.labToday18PM = new System.Windows.Forms.Label();
            this.labToday12PM = new System.Windows.Forms.Label();
            this.labToday9AM = new System.Windows.Forms.Label();
            this.imgTomorrow18PM = new System.Windows.Forms.PictureBox();
            this.imgTomorrow12PM = new System.Windows.Forms.PictureBox();
            this.imgTomorrow9AM = new System.Windows.Forms.PictureBox();
            this.imgToday18PM = new System.Windows.Forms.PictureBox();
            this.imgToday12PM = new System.Windows.Forms.PictureBox();
            this.imgToday9AM = new System.Windows.Forms.PictureBox();
            this.weatherTimer = new System.Windows.Forms.Timer(this.components);
            this.MqttTimer = new System.Windows.Forms.Timer(this.components);
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelStockSubMenu.SuspendLayout();
            this.panelWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTomorrow18PM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTomorrow12PM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTomorrow9AM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToday18PM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToday12PM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToday9AM)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.butPcPower);
            this.panelMenu.Controls.Add(this.butLedPower);
            this.panelMenu.Controls.Add(this.panelStockSubMenu);
            this.panelMenu.Controls.Add(this.butStock);
            this.panelMenu.Controls.Add(this.butMain);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(229, 1000);
            this.panelMenu.TabIndex = 0;
            // 
            // butPcPower
            // 
            this.butPcPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.butPcPower.Dock = System.Windows.Forms.DockStyle.Top;
            this.butPcPower.FlatAppearance.BorderSize = 0;
            this.butPcPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPcPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.butPcPower.ForeColor = System.Drawing.Color.White;
            this.butPcPower.Location = new System.Drawing.Point(0, 787);
            this.butPcPower.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butPcPower.Name = "butPcPower";
            this.butPcPower.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.butPcPower.Size = new System.Drawing.Size(229, 125);
            this.butPcPower.TabIndex = 5;
            this.butPcPower.Text = "PC On/Off";
            this.butPcPower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butPcPower.UseVisualStyleBackColor = false;
            this.butPcPower.Click += new System.EventHandler(this.pcPower_Click);
            // 
            // butLedPower
            // 
            this.butLedPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.butLedPower.Dock = System.Windows.Forms.DockStyle.Top;
            this.butLedPower.FlatAppearance.BorderSize = 0;
            this.butLedPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLedPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.butLedPower.ForeColor = System.Drawing.Color.White;
            this.butLedPower.Location = new System.Drawing.Point(0, 662);
            this.butLedPower.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butLedPower.Name = "butLedPower";
            this.butLedPower.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.butLedPower.Size = new System.Drawing.Size(229, 125);
            this.butLedPower.TabIndex = 4;
            this.butLedPower.Text = "LED On/Off";
            this.butLedPower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLedPower.UseVisualStyleBackColor = false;
            this.butLedPower.Click += new System.EventHandler(this.ledPower_Click);
            // 
            // panelStockSubMenu
            // 
            this.panelStockSubMenu.Controls.Add(this.butStockTotal);
            this.panelStockSubMenu.Controls.Add(this.butStockMonth);
            this.panelStockSubMenu.Controls.Add(this.butStockWeek);
            this.panelStockSubMenu.Controls.Add(this.butStockDay);
            this.panelStockSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStockSubMenu.Location = new System.Drawing.Point(0, 412);
            this.panelStockSubMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelStockSubMenu.Name = "panelStockSubMenu";
            this.panelStockSubMenu.Size = new System.Drawing.Size(229, 250);
            this.panelStockSubMenu.TabIndex = 3;
            // 
            // butStockTotal
            // 
            this.butStockTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.butStockTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.butStockTotal.FlatAppearance.BorderSize = 0;
            this.butStockTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butStockTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.butStockTotal.ForeColor = System.Drawing.Color.White;
            this.butStockTotal.Location = new System.Drawing.Point(0, 186);
            this.butStockTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butStockTotal.Name = "butStockTotal";
            this.butStockTotal.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.butStockTotal.Size = new System.Drawing.Size(229, 62);
            this.butStockTotal.TabIndex = 3;
            this.butStockTotal.Text = "Total";
            this.butStockTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butStockTotal.UseVisualStyleBackColor = false;
            this.butStockTotal.Click += new System.EventHandler(this.butStockTotal_Click);
            // 
            // butStockMonth
            // 
            this.butStockMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.butStockMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.butStockMonth.FlatAppearance.BorderSize = 0;
            this.butStockMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butStockMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.butStockMonth.ForeColor = System.Drawing.Color.White;
            this.butStockMonth.Location = new System.Drawing.Point(0, 124);
            this.butStockMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butStockMonth.Name = "butStockMonth";
            this.butStockMonth.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.butStockMonth.Size = new System.Drawing.Size(229, 62);
            this.butStockMonth.TabIndex = 2;
            this.butStockMonth.Text = "Month";
            this.butStockMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butStockMonth.UseVisualStyleBackColor = false;
            this.butStockMonth.Click += new System.EventHandler(this.butStockMonth_Click);
            // 
            // butStockWeek
            // 
            this.butStockWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.butStockWeek.Dock = System.Windows.Forms.DockStyle.Top;
            this.butStockWeek.FlatAppearance.BorderSize = 0;
            this.butStockWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butStockWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.butStockWeek.ForeColor = System.Drawing.Color.White;
            this.butStockWeek.Location = new System.Drawing.Point(0, 62);
            this.butStockWeek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butStockWeek.Name = "butStockWeek";
            this.butStockWeek.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.butStockWeek.Size = new System.Drawing.Size(229, 62);
            this.butStockWeek.TabIndex = 1;
            this.butStockWeek.Text = "Week";
            this.butStockWeek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butStockWeek.UseVisualStyleBackColor = false;
            this.butStockWeek.Click += new System.EventHandler(this.butStockWeek_Click);
            // 
            // butStockDay
            // 
            this.butStockDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.butStockDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.butStockDay.FlatAppearance.BorderSize = 0;
            this.butStockDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butStockDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.butStockDay.ForeColor = System.Drawing.Color.White;
            this.butStockDay.Location = new System.Drawing.Point(0, 0);
            this.butStockDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butStockDay.Name = "butStockDay";
            this.butStockDay.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.butStockDay.Size = new System.Drawing.Size(229, 62);
            this.butStockDay.TabIndex = 0;
            this.butStockDay.Text = "Day";
            this.butStockDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butStockDay.UseVisualStyleBackColor = false;
            this.butStockDay.Click += new System.EventHandler(this.butStockDay_Click);
            // 
            // butStock
            // 
            this.butStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.butStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.butStock.FlatAppearance.BorderSize = 0;
            this.butStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.butStock.ForeColor = System.Drawing.Color.White;
            this.butStock.Location = new System.Drawing.Point(0, 287);
            this.butStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butStock.Name = "butStock";
            this.butStock.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.butStock.Size = new System.Drawing.Size(229, 125);
            this.butStock.TabIndex = 2;
            this.butStock.Text = "Stock";
            this.butStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butStock.UseVisualStyleBackColor = false;
            this.butStock.Click += new System.EventHandler(this.butStock_Click);
            // 
            // butMain
            // 
            this.butMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.butMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.butMain.FlatAppearance.BorderSize = 0;
            this.butMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.butMain.ForeColor = System.Drawing.Color.White;
            this.butMain.Location = new System.Drawing.Point(0, 162);
            this.butMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butMain.Name = "butMain";
            this.butMain.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.butMain.Size = new System.Drawing.Size(229, 125);
            this.butMain.TabIndex = 1;
            this.butMain.Text = "Main";
            this.butMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butMain.UseVisualStyleBackColor = false;
            this.butMain.Click += new System.EventHandler(this.butMain_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(229, 162);
            this.panelLogo.TabIndex = 0;
            // 
            // panelWeather
            // 
            this.panelWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelWeather.Controls.Add(this.labTomorrow18PM);
            this.panelWeather.Controls.Add(this.labTomorrow12PM);
            this.panelWeather.Controls.Add(this.labTomorrow9AM);
            this.panelWeather.Controls.Add(this.labToday18PM);
            this.panelWeather.Controls.Add(this.labToday12PM);
            this.panelWeather.Controls.Add(this.labToday9AM);
            this.panelWeather.Controls.Add(this.imgTomorrow18PM);
            this.panelWeather.Controls.Add(this.imgTomorrow12PM);
            this.panelWeather.Controls.Add(this.imgTomorrow9AM);
            this.panelWeather.Controls.Add(this.imgToday18PM);
            this.panelWeather.Controls.Add(this.imgToday12PM);
            this.panelWeather.Controls.Add(this.imgToday9AM);
            this.panelWeather.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWeather.Location = new System.Drawing.Point(229, 0);
            this.panelWeather.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelWeather.Name = "panelWeather";
            this.panelWeather.Size = new System.Drawing.Size(1234, 162);
            this.panelWeather.TabIndex = 1;
            // 
            // labTomorrow18PM
            // 
            this.labTomorrow18PM.BackColor = System.Drawing.Color.Transparent;
            this.labTomorrow18PM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTomorrow18PM.ForeColor = System.Drawing.Color.White;
            this.labTomorrow18PM.Location = new System.Drawing.Point(1004, 6);
            this.labTomorrow18PM.Name = "labTomorrow18PM";
            this.labTomorrow18PM.Size = new System.Drawing.Size(130, 32);
            this.labTomorrow18PM.TabIndex = 10;
            this.labTomorrow18PM.Text = "10.18 18PM";
            this.labTomorrow18PM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labTomorrow12PM
            // 
            this.labTomorrow12PM.BackColor = System.Drawing.Color.Transparent;
            this.labTomorrow12PM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTomorrow12PM.ForeColor = System.Drawing.Color.White;
            this.labTomorrow12PM.Location = new System.Drawing.Point(819, 6);
            this.labTomorrow12PM.Name = "labTomorrow12PM";
            this.labTomorrow12PM.Size = new System.Drawing.Size(130, 32);
            this.labTomorrow12PM.TabIndex = 9;
            this.labTomorrow12PM.Text = "10.18 12PM";
            this.labTomorrow12PM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labTomorrow9AM
            // 
            this.labTomorrow9AM.BackColor = System.Drawing.Color.Transparent;
            this.labTomorrow9AM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTomorrow9AM.ForeColor = System.Drawing.Color.White;
            this.labTomorrow9AM.Location = new System.Drawing.Point(640, 6);
            this.labTomorrow9AM.Name = "labTomorrow9AM";
            this.labTomorrow9AM.Size = new System.Drawing.Size(130, 32);
            this.labTomorrow9AM.TabIndex = 8;
            this.labTomorrow9AM.Text = "10.18 9AM";
            this.labTomorrow9AM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labToday18PM
            // 
            this.labToday18PM.BackColor = System.Drawing.Color.Transparent;
            this.labToday18PM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToday18PM.ForeColor = System.Drawing.Color.White;
            this.labToday18PM.Location = new System.Drawing.Point(464, 6);
            this.labToday18PM.Name = "labToday18PM";
            this.labToday18PM.Size = new System.Drawing.Size(130, 32);
            this.labToday18PM.TabIndex = 7;
            this.labToday18PM.Text = "10.17 18PM";
            this.labToday18PM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labToday12PM
            // 
            this.labToday12PM.BackColor = System.Drawing.Color.Transparent;
            this.labToday12PM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToday12PM.ForeColor = System.Drawing.Color.White;
            this.labToday12PM.Location = new System.Drawing.Point(289, 6);
            this.labToday12PM.Name = "labToday12PM";
            this.labToday12PM.Size = new System.Drawing.Size(130, 32);
            this.labToday12PM.TabIndex = 6;
            this.labToday12PM.Text = "10.17 12PM";
            this.labToday12PM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labToday9AM
            // 
            this.labToday9AM.BackColor = System.Drawing.Color.Transparent;
            this.labToday9AM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToday9AM.ForeColor = System.Drawing.Color.White;
            this.labToday9AM.Location = new System.Drawing.Point(105, 6);
            this.labToday9AM.Name = "labToday9AM";
            this.labToday9AM.Size = new System.Drawing.Size(130, 32);
            this.labToday9AM.TabIndex = 2;
            this.labToday9AM.Text = "10.17 9AM";
            this.labToday9AM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgTomorrow18PM
            // 
            this.imgTomorrow18PM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imgTomorrow18PM.Location = new System.Drawing.Point(1018, 44);
            this.imgTomorrow18PM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgTomorrow18PM.Name = "imgTomorrow18PM";
            this.imgTomorrow18PM.Size = new System.Drawing.Size(104, 114);
            this.imgTomorrow18PM.TabIndex = 5;
            this.imgTomorrow18PM.TabStop = false;
            // 
            // imgTomorrow12PM
            // 
            this.imgTomorrow12PM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imgTomorrow12PM.Location = new System.Drawing.Point(833, 44);
            this.imgTomorrow12PM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgTomorrow12PM.Name = "imgTomorrow12PM";
            this.imgTomorrow12PM.Size = new System.Drawing.Size(104, 114);
            this.imgTomorrow12PM.TabIndex = 4;
            this.imgTomorrow12PM.TabStop = false;
            // 
            // imgTomorrow9AM
            // 
            this.imgTomorrow9AM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imgTomorrow9AM.Location = new System.Drawing.Point(655, 44);
            this.imgTomorrow9AM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgTomorrow9AM.Name = "imgTomorrow9AM";
            this.imgTomorrow9AM.Size = new System.Drawing.Size(104, 114);
            this.imgTomorrow9AM.TabIndex = 3;
            this.imgTomorrow9AM.TabStop = false;
            // 
            // imgToday18PM
            // 
            this.imgToday18PM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imgToday18PM.Location = new System.Drawing.Point(479, 44);
            this.imgToday18PM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgToday18PM.Name = "imgToday18PM";
            this.imgToday18PM.Size = new System.Drawing.Size(104, 114);
            this.imgToday18PM.TabIndex = 2;
            this.imgToday18PM.TabStop = false;
            // 
            // imgToday12PM
            // 
            this.imgToday12PM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imgToday12PM.Location = new System.Drawing.Point(304, 44);
            this.imgToday12PM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgToday12PM.Name = "imgToday12PM";
            this.imgToday12PM.Size = new System.Drawing.Size(104, 114);
            this.imgToday12PM.TabIndex = 1;
            this.imgToday12PM.TabStop = false;
            // 
            // imgToday9AM
            // 
            this.imgToday9AM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imgToday9AM.Location = new System.Drawing.Point(121, 44);
            this.imgToday9AM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgToday9AM.Name = "imgToday9AM";
            this.imgToday9AM.Size = new System.Drawing.Size(104, 114);
            this.imgToday9AM.TabIndex = 0;
            this.imgToday9AM.TabStop = false;
            // 
            // weatherTimer
            // 
            this.weatherTimer.Enabled = true;
            this.weatherTimer.Interval = 60000;
            this.weatherTimer.Tick += new System.EventHandler(this.weatherTimer_Tick);
            // 
            // MqttTimer
            // 
            this.MqttTimer.Enabled = true;
            this.MqttTimer.Interval = 300000;
            this.MqttTimer.Tick += new System.EventHandler(this.MqttTimer_Tick);
            // 
            // panelDisplay
            // 
            this.panelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplay.Location = new System.Drawing.Point(229, 162);
            this.panelDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(1234, 838);
            this.panelDisplay.TabIndex = 2;
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1463, 1000);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.panelWeather);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "menuForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.menuForm_FormClosed);
            this.Load += new System.EventHandler(this.menuForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelStockSubMenu.ResumeLayout(false);
            this.panelWeather.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgTomorrow18PM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTomorrow12PM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTomorrow9AM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToday18PM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToday12PM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToday9AM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelStockSubMenu;
        private System.Windows.Forms.Button butStockTotal;
        private System.Windows.Forms.Button butStockMonth;
        private System.Windows.Forms.Button butStockWeek;
        private System.Windows.Forms.Button butStockDay;
        private System.Windows.Forms.Button butStock;
        private System.Windows.Forms.Button butMain;
        private System.Windows.Forms.Button butPcPower;
        private System.Windows.Forms.Button butLedPower;
        private System.Windows.Forms.Panel panelWeather;
        private System.Windows.Forms.PictureBox imgTomorrow18PM;
        private System.Windows.Forms.PictureBox imgTomorrow12PM;
        private System.Windows.Forms.PictureBox imgTomorrow9AM;
        private System.Windows.Forms.PictureBox imgToday18PM;
        private System.Windows.Forms.PictureBox imgToday12PM;
        private System.Windows.Forms.PictureBox imgToday9AM;
        private System.Windows.Forms.Timer weatherTimer;
        private System.Windows.Forms.Timer MqttTimer;
        private System.Windows.Forms.Label labToday9AM;
        private System.Windows.Forms.Label labTomorrow18PM;
        private System.Windows.Forms.Label labTomorrow12PM;
        private System.Windows.Forms.Label labTomorrow9AM;
        private System.Windows.Forms.Label labToday18PM;
        private System.Windows.Forms.Label labToday12PM;
        private System.Windows.Forms.Panel panelDisplay;
    }
}

