using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOME_IOT_NEW_SKIN
{
    class Weather
    {
        private string cityName;
        private string date;
        private string weatherStatus;

        public Weather()
        {
            cityName = "Ansan";
        }

        public string Date
        {
            get { return Date; }
            set { Date = value; }
        }

        public string WeatherStatus
        {
            get { return weatherStatus; }
            set { weatherStatus = value; }
        }

    }
}
