using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOME_IOT_NEW_SKIN
{
    public class Stock
    {
        enum XML_ORDER { DATE, END, HIGH, LOW, CUR};
        private bool isInit;
        private List<KeyValuePair<string, int>> dates;              // 주식 취득 일자 리스트
        private string name;                                                       // 주식 이름
        private string date;                                                         // 금일
        private string code;                                                             // 종목코드
        private int curPrice;                                                        // 주식 현재가격
        private int highPrice;                                                      // 주식 고가
        private int lowPrice;                                                       // 주식 저가
        private int endPriceYesterday;                                      // 주식 어제 종가
        private int purchasePrice;                                             // 한 주당 구매 단가
        private int count;                                                           // 소유 주식 개수
        private int totalPurPrice;
        private int totalCurPrice;                                                // 현재 주식 총 금액
        private double margin;                                                  // 이윤

        public Stock()
        {
            this.dates = new List<KeyValuePair<string, int>>();
            this.isInit = false;
            this.name = null;
            this.date = null;
            this.code = null;
            this.curPrice = 0;
            this.highPrice = 0;
            this.lowPrice = 0;
            this.endPriceYesterday = 0;
            this.purchasePrice = 0;
            this.count = 0;
            this.totalCurPrice = 0;
            this.totalPurPrice = 0;
            this.margin = 0;
        }

        public void Initialize(string stockName, string stockCode, int cnt, int price)
        {
            this.dates.Add(new KeyValuePair<string, int>(DateTime.Now.ToString(), cnt));
            this.name = stockName;
            this.code = stockCode;
            this.count = cnt;
            this.purchasePrice = price;
            this.totalPurPrice= this.count * this.purchasePrice;
            this.totalCurPrice = this.totalPurPrice;
            this.margin = 0.0;
            this.isInit = true;
        }

        public bool Update(string xmlStr)
        {
            // Xml파싱 문자열이 규격에 맞지 않다면 return;
            if (xmlStr.Substring(0, 10).CompareTo("<item data") != 0)
                return false;
            if (!this.isInit)
                return false;

            // 주식 가격과 |문자만 남기고 앞뒤 자르기
            string price = xmlStr.Substring(12);
            price = price.Remove(price.Length - 4, 4);
            string[] prices = price.Split('|');

            // 주식 정보 업데이트
            this.date = prices[OrderToInt(XML_ORDER.DATE)];
            this.endPriceYesterday = Int32.Parse(prices[OrderToInt(XML_ORDER.END)]);
            this.highPrice = Int32.Parse(prices[OrderToInt(XML_ORDER.HIGH)]);
            this.lowPrice = Int32.Parse(prices[OrderToInt(XML_ORDER.LOW)]);
            this.curPrice = Int32.Parse(prices[OrderToInt(XML_ORDER.CUR)]);
            this.totalCurPrice = this.count * this.curPrice;

            // 현재 이윤 설정( 현재1주당 가격 / 구매1주당 가격 )
            this.margin = (double)this.curPrice / (double)this.purchasePrice;
            this.margin -= 1.0; this.margin *= 100.0; this.margin = Math.Round(this.Margin * 100) / 100;

            return true;
        }

        public void SellStock(int cnt)
        {
            if(cnt > this.count || cnt < 0)
            {
                return;
            }

            this.count -= cnt;
            this.dates.Add(new KeyValuePair<string, int>(DateTime.Now.ToString(), cnt));
        }

        public void BuyStock(int cnt, int price)
        {
            if (cnt < 0 || price < 0)
                return;

            // 평균 매입 단가 계산
            int _totalPrice = cnt * price;
            double meanPurPrice = (double)(this.totalCurPrice + _totalPrice) / (double)(cnt + this.count);

            // 주식 수, 평균 매입 단가 재설정
            this.count += cnt;
            this.purchasePrice = (int)meanPurPrice;
            this.totalPurPrice = this.count * this.purchasePrice;
            this.dates.Add(new KeyValuePair<string, int>(DateTime.Now.ToString(), cnt));
        }

        public string Name
        {
            get { return this.name; }
        }

        public string Code
        {
            get { return this.code; }
        }

        public int CurPrice
        {
            get { return this.curPrice; }
        }

        public int HighPrice
        {
            get { return this.highPrice; }
        }

        public int LowPrice
        {
            get { return this.lowPrice; }
        }

        public int EndPriceYesterday
        {
            get { return this.endPriceYesterday; }
        }

        public int PurchasePrice
        {
            get { return this.purchasePrice; }   
        }

        public int Count
        {
            get { return this.count; }
        }

        public int TotalCurPrice
        {
            get { return this.totalCurPrice; }
        }

        public int TotalPurPrice
        {
            get { return this.totalPurPrice; }
        }

        public double Margin
        {
            get { return this.margin; }
        }

        public bool Isinit
        {
            get { return isInit; }
        }

        private int OrderToInt(XML_ORDER order)
        {
            return (int)order;
        }

    }
}
