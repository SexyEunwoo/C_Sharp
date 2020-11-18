namespace HOME_IOT_NEW_SKIN
{
    partial class StockSellForm
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
            this.butCancel = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.labPrice = new System.Windows.Forms.Label();
            this.labCount = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textCount = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(226, 316);
            this.butCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(86, 29);
            this.butCancel.TabIndex = 25;
            this.butCancel.Text = "취소";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(71, 316);
            this.butAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(86, 29);
            this.butAdd.TabIndex = 24;
            this.butAdd.Text = "판매";
            this.butAdd.UseVisualStyleBackColor = true;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(73, 242);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(92, 15);
            this.labPrice.TabIndex = 23;
            this.labPrice.Text = "한 주당 가격";
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Location = new System.Drawing.Point(73, 175);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(72, 15);
            this.labCount.TabIndex = 22;
            this.labCount.Text = "판매 개수";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(73, 110);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(67, 15);
            this.labName.TabIndex = 21;
            this.labName.Text = "회사이름";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(198, 238);
            this.textPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(114, 25);
            this.textPrice.TabIndex = 20;
            // 
            // textCount
            // 
            this.textCount.Location = new System.Drawing.Point(198, 172);
            this.textCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textCount.Name = "textCount";
            this.textCount.Size = new System.Drawing.Size(114, 25);
            this.textCount.TabIndex = 19;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(198, 106);
            this.textName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(114, 25);
            this.textName.TabIndex = 18;
            // 
            // StockSellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 451);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textCount);
            this.Controls.Add(this.textName);
            this.Name = "StockSellForm";
            this.Text = "StockSellForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textCount;
        private System.Windows.Forms.TextBox textName;
    }
}