namespace HOME_IOT_NEW_SKIN
{
    partial class StockAddForm
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
            this.textName = new System.Windows.Forms.TextBox();
            this.textCount = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.labCount = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.butAdd = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(167, 82);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 21);
            this.textName.TabIndex = 1;
            // 
            // textCount
            // 
            this.textCount.Location = new System.Drawing.Point(167, 134);
            this.textCount.Name = "textCount";
            this.textCount.Size = new System.Drawing.Size(100, 21);
            this.textCount.TabIndex = 2;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(167, 187);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 21);
            this.textPrice.TabIndex = 3;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(58, 85);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(53, 12);
            this.labName.TabIndex = 5;
            this.labName.Text = "회사이름";
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Location = new System.Drawing.Point(58, 137);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(57, 12);
            this.labCount.TabIndex = 6;
            this.labCount.Text = "구매 개수";
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(58, 190);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(73, 12);
            this.labPrice.TabIndex = 7;
            this.labPrice.Text = "한 주당 가격";
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(56, 250);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 8;
            this.butAdd.Text = "추가";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(192, 250);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 9;
            this.butCancel.Text = "취소";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // StockAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textCount);
            this.Controls.Add(this.textName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StockAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "StockAddForm";
            this.Load += new System.EventHandler(this.StockAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textCount;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butCancel;
    }
}