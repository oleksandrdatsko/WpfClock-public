using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherAPI.Models
{
    public class WeatherForecastModel
    {
        public int Cnt { get; set; }
        public List<List> list { get; set; }

        public class List
        {
            public int Dt { get; set; }
            public Main main { get; set; }
            public List<Weather> weather { get; set; }

            public class Main
            {
                public double Temp { get; set; }
                public double Temp_min { get; set; }
                public double Temp_max { get; set; }
            }

            public class Weather
            {
                public string Description { get; set; }
                public string Icon { get; set; }
            }
        }
    }
}
