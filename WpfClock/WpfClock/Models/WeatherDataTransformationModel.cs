using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class WeatherDataTransformationModel
    {
        public DateTime GetFullDateFromUnix(int millisec)
        {
            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            day = day.AddSeconds(millisec).ToLocalTime();
            return day;
        }

        public DayOfWeek GetDayOfWeekFromUnix(int millisec)
        {
            return GetFullDateFromUnix(millisec).DayOfWeek;
        }

        public string GetDateMMMDDFromUnix(int millisec)
        {
            return string.Format("{0:MMM, dd}",GetFullDateFromUnix(millisec));
        }

        public string FormatTemperatureCelsicus(double Temp)
        {
            //if(DefaultValuesModel.Units == "metric")
            //{
            //return $"{ Math.Round(Temp, 0) }\u00B0" + "C";
            //}
            //else
            //{
            return $"{ Math.Round(Temp, 0) }\u00B0" + "F";
            //}

        }

        public string FormatHumidity(double Humidity)
        {
            return $"{ Humidity }%";
        }

        public string FormatWindSpeedMetric(double WindSpeed)
        {
            //if(DefaultValuesModel.Units == "metric")
            //{
                return $"{ WindSpeed }m/sec";
            //}
            //else
            //{
            //    return $"{ WindSpeed }m/h";
            //}
            
        }

        public string GetWindCompassDirection(double MeteoDegrees)
        {
            List<string> CompassDirections = new List<string> { "N", "NNE", "NE", "ENE", "E", "ESE", "SE", "SSE", "S", "SSW", "SW", "WSW", "W", "WNW", "NW", "NNW", "N" };

            int CompassDirectionIndex = (int)Math.Round(((MeteoDegrees % 360.0) / 22.5));

            return CompassDirections[CompassDirectionIndex];
        }

        public string GetImageUrl(string ImageId)
        {
            return $"http://openweathermap.org/img/wn/{ ImageId }@2x.png";
        }
    }
}
