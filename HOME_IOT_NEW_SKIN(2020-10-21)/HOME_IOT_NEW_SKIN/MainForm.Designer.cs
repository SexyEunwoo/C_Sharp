namespace HOME_IOT_NEW_SKIN
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labPcTemp = new System.Windows.Forms.Label();
            this.labPcHumi = new System.Windows.Forms.Label();
            this.panelBlank1 = new System.Windows.Forms.Panel();
            this.panelBlank2 = new System.Windows.Forms.Panel();
            this.labBlank1 = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelPcTemp = new System.Windows.Forms.Panel();
            this.imgComputer = new System.Windows.Forms.PictureBox();
            this.panelPcTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputer)).BeginInit();
            this.SuspendLayout();
            // 
            // labPcTemp
            // 
            this.labPcTemp.BackColor = System.Drawing.Color.Transparent;
            this.labPcTemp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labPcTemp.Font = new System.Drawing.Font("LAB디지털", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labPcTemp.ForeColor = System.Drawing.Color.White;
            this.labPcTemp.Location = new System.Drawing.Point(0, 107);
            this.labPcTemp.Name = "labPcTemp";
            this.labPcTemp.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.labPcTemp.Size = new System.Drawing.Size(170, 43);
            this.labPcTemp.TabIndex = 12;
            this.labPcTemp.Text = "21.5℃";
            this.labPcTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labPcHumi
            // 
            this.labPcHumi.BackColor = System.Drawing.Color.Transparent;
            this.labPcHumi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labPcHumi.Font = new System.Drawing.Font("LAB디지털", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labPcHumi.ForeColor = System.Drawing.Color.White;
            this.labPcHumi.Location = new System.Drawing.Point(0, 64);
            this.labPcHumi.Name = "labPcHumi";
            this.labPcHumi.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.labPcHumi.Size = new System.Drawing.Size(170, 43);
            this.labPcHumi.TabIndex = 11;
            this.labPcHumi.Text = "75%";
            this.labPcHumi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBlank1
            // 
            this.panelBlank1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBlank1.Location = new System.Drawing.Point(0, 0);
            this.panelBlank1.Name = "panelBlank1";
            this.panelBlank1.Size = new System.Drawing.Size(120, 670);
            this.panelBlank1.TabIndex = 14;
            // 
            // panelBlank2
            // 
            this.panelBlank2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBlank2.Location = new System.Drawing.Point(961, 0);
            this.panelBlank2.Name = "panelBlank2";
            this.panelBlank2.Size = new System.Drawing.Size(119, 670);
            this.panelBlank2.TabIndex = 15;
            // 
            // labBlank1
            // 
            this.labBlank1.BackColor = System.Drawing.Color.Transparent;
            this.labBlank1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labBlank1.Location = new System.Drawing.Point(0, 150);
            this.labBlank1.Name = "labBlank1";
            this.labBlank1.Size = new System.Drawing.Size(170, 20);
            this.labBlank1.TabIndex = 15;
            // 
            // labTime
            // 
            this.labTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.labTime.Font = new System.Drawing.Font("LAB디지털", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labTime.ForeColor = System.Drawing.Color.White;
            this.labTime.Location = new System.Drawing.Point(120, 0);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(841, 97);
            this.labTime.TabIndex = 17;
            this.labTime.Text = "10.07(수) 15:49";
            this.labTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelPcTemp
            // 
            this.panelPcTemp.Controls.Add(this.labPcHumi);
            this.panelPcTemp.Controls.Add(this.labPcTemp);
            this.panelPcTemp.Controls.Add(this.labBlank1);
            this.panelPcTemp.Controls.Add(this.imgComputer);
            this.panelPcTemp.Location = new System.Drawing.Point(270, 117);
            this.panelPcTemp.Name = "panelPcTemp";
            this.panelPcTemp.Size = new System.Drawing.Size(170, 170);
            this.panelPcTemp.TabIndex = 18;
            // 
            // imgComputer
            // 
            this.imgComputer.BackColor = System.Drawing.Color.Transparent;
            this.imgComputer.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgComputer.Image = global::HOME_IOT_NEW_SKIN.Properties.Resources.CPU2;
            this.imgComputer.Location = new System.Drawing.Point(0, 0);
            this.imgComputer.Name = "imgComputer";
            this.imgComputer.Size = new System.Drawing.Size(170, 75);
            this.imgComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgComputer.TabIndex = 14;
            this.imgComputer.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1080, 670);
            this.Controls.Add(this.panelPcTemp);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.panelBlank2);
            this.Controls.Add(this.panelBlank1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelPcTemp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgComputer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox imgComputer;
        private System.Windows.Forms.Label labPcTemp;
        private System.Windows.Forms.Label labPcHumi;
        private System.Windows.Forms.Panel panelBlank1;
        private System.Windows.Forms.Panel panelBlank2;
        private System.Windows.Forms.Label labBlank1;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelPcTemp;
    }
}