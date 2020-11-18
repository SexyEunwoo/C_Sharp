namespace HOME_IOT_NEW_SKIN
{
    partial class StockDelForm
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
            this.labName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(226, 294);
            this.butCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(86, 29);
            this.butCancel.TabIndex = 25;
            this.butCancel.Text = "취소";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(71, 294);
            this.butAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(86, 29);
            this.butAdd.TabIndex = 24;
            this.butAdd.Text = "삭제";
            this.butAdd.UseVisualStyleBackColor = true;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(73, 190);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(67, 15);
            this.labName.TabIndex = 21;
            this.labName.Text = "회사이름";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(198, 186);
            this.textName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(114, 25);
            this.textName.TabIndex = 18;
            // 
            // StockDelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 451);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.textName);
            this.Name = "StockDelForm";
            this.Text = "StockDelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox textName;
    }
}