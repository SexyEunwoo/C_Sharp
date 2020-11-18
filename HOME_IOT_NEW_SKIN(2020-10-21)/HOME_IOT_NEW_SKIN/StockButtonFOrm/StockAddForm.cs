using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace HOME_IOT_NEW_SKIN
{
    public partial class StockAddForm : Form
    {
        public string name;
        public string code;
        public int count;
        public int price;

        public StockAddForm()
        {
            InitializeComponent();
        }

        private void StockAddForm_Load(object sender, EventArgs e)
        {
            name = null;
            code = null;
            count = 0;
            price = 0;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            #region CheckTextbox

            if (this.textName.Text.CompareTo("") == 0)
            {
                MessageBox.Show("이름칸이 비어있습니다");
                return;
            }
            if (this.textCount.Text.CompareTo("") == 0)
            {
                MessageBox.Show("개수칸이 비어있습니다");
                return;
            }
            if (this.textPrice.Text.CompareTo("") == 0)
            {
                MessageBox.Show("가격칸이 비어있습니다");
                return;
            }

            #endregion

            #region CheckAvailabilityCodeAndSetProperties


            for(int i = 0; i < StockDayForm.stockTodayPrice.Length; i++)
            {
                if(StockDayForm.stockTodayPrice[i].Isinit && StockDayForm.stockTodayPrice[i].Name.CompareTo(this.textName.Text) == 0)
                {
                    MessageBox.Show("이미 등록된 주식입니다.");
                    break;
                }
            }

            bool isAvailable = false;

            for (int i = 0; i < menuForm.codes.Count; i++)
            {
                if( this.textName.Text.CompareTo(menuForm.codes[i].Key) == 0 ) // 실제로 존재하는 종목코드라면
                {
                    this.name = menuForm.codes[i].Key;
                    this.code = menuForm.codes[i].Value;
                    this.count = Int32.Parse(textCount.Text);
                    this.price = Int32.Parse(textPrice.Text);

                    isAvailable = true;
                    break;
                }
            }

            if(!isAvailable)
            {
                MessageBox.Show("존재하지 않는 회사이름입니다!");
                return;
            }

            #endregion

            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
