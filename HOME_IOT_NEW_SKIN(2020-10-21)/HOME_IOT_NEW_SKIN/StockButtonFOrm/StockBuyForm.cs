using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOME_IOT_NEW_SKIN
{
    public partial class StockBuyForm : Form
    {
        public string name;
        public int cnt;
        public int price;
        public int idx;

        public StockBuyForm()
        {
            InitializeComponent();
        }

        private void StockBuyForm_Load(object sender, EventArgs e)
        {
            this.name = null;
            this.cnt = 0;
            this.price = 0;
            this.idx = -1;
        }

        private void butBuy_Click(object sender, EventArgs e)
        {
            #region CheckTextBox

            if(this.textName.Text.CompareTo("") == 0)
            {
                MessageBox.Show("이름칸이 비어있습니다.");
                return;
            }
            if(this.textCount.Text.CompareTo("") == 0)
            {
                MessageBox.Show("개수칸이 비어있습니다.");
                return;
            }
            if(this.textPrice.Text.CompareTo("") == 0)
            {
                MessageBox.Show("가격칸이 비어있습니다.");
                return;
            }

            #endregion

            #region CheckAvailability

            bool isAvailable = false;
            for(int i = 0; i < StockDayForm.stockTodayPrice.Length; i++)
            {
                if(StockDayForm.stockTodayPrice[i].Isinit && StockDayForm.stockTodayPrice[i].Name.CompareTo(this.textName.Text) == 0)
                {
                    idx = i;
                    this.name = textName.Text;
                    this.cnt = Int32.Parse(textCount.Text);
                    this.price = Int32.Parse(textPrice.Text);
                    isAvailable = true;
                }
            }
            
            if(isAvailable)
            {
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Hide();
            }

            #endregion
        }
    }
}
