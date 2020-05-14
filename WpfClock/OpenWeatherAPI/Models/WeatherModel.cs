using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherAPI.Models
{
    public class WeatherModel
    {
        public List<Weather> weather { get; set; }
        public Main main { get; set; }
        public Wind wind { get; set; }
        public Sys sys { get; set; }

        public int Dt { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public static bool operator == (WeatherModel A, WeatherModel B)
        {
            bool weatherCompare = false;

            if (A.weather.Count == B.weather.Count)
            {
                for(int i = 0; i < A.weather.Count; i++)
                {
                    weatherCompare = A.weather[i] == B.weather[i];
                }
            }

            return weatherCompare &&
                    A.main == B.main &&
                    A.wind == B.wind &&
                    A.sys == B.sys &&
                    A.Dt == B.Dt &&
                    A.Id == B.Id &&
                    A.Name == B.Name;
        }

        public static bool operator !=(WeatherModel A, WeatherModel B)
        {

            bool weatherCompare = true;

            if (A.weather.Count == B.weather.Count)
            {
                for (int i = 0; i < A.weather.Count; i++)
                {
                    weatherCompare = A.weather[i] != B.weather[i];
                }
            }

            return weatherCompare ||
                    A.main != B.main ||
                    A.wind != B.wind ||
                    A.sys != B.sys ||
                    A.Dt != B.Dt ||
                    A.Id != B.Id ||
                    A.Name != B.Name;
        }

    }

    public class Weather
    {
        public string Description { get; set; }
        public string Icon { get; set; }

        public static bool operator == (Weather A, Weather B)
        {
            return A.Description == B.Description &&
                    A.Icon == B.Icon;
        }

        public static bool operator != (Weather A, Weather B)
        {
            return A.Description != B.Description ||
                    A.Icon != B.Icon;
        }
    }

    public class Main
    {
        public double Temp { get; set; }
        public double Pressure { get; set; }
        public double Humidity { get; set; }
        public double Temp_min { get; set; }
        public double Temp_max { get; set; }

        public static bool operator == (Main A, Main B)
        {
            return A.Temp == B.Temp &&
                    A.Pressure == B.Pressure &&
                    A.Humidity == B.Humidity &&
                    A.Temp_min == B.Temp_min &&
                    A.Temp_max == B.Temp_max;
        }

        public static bool operator != (Main A, Main B)
        {
            return A.Temp != B.Temp ||
                    A.Pressure != B.Pressure ||
                    A.Humidity != B.Humidity ||
                    A.Temp_min != B.Temp_min ||
                    A.Temp_max != B.Temp_max;
        }

    }

    public class Wind
    {
        public double Speed { get; set; }
        public double Deg { get; set; }

        public static bool operator == (Wind A, Wind B)
        {
            return A.Speed == B.Speed && 
                    A.Deg == B.Deg;
        }

        public static bool operator != (Wind A, Wind B)
        {
            return A.Speed != B.Speed || 
                    A.Deg != B.Deg;
        }
    }

    public class Sys
    {
        public string Country { get; set; }

        public static bool operator == (Sys A, Sys B)
        {
            return A.Country == B.Country;
        }

        public static bool operator != (Sys A, Sys B)
        {
            return A.Country != B.Country;
        }
    }

}
