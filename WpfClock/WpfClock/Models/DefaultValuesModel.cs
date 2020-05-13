using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClock.Models
{
    public static class DefaultValuesModel
    {
        //private static int _cityID = Properties.Settings.Default.CityId;
        //private static string _cityName = Properties.Settings.Default.CityName;
        //private static string _APIKey = Properties.Settings.Default.APIKey;
        //private static string _units = Properties.Settings.Default.Units;
        //private static int _refreshInterval = Properties.Settings.Default.RefreshFrequencyMinutes;
        //private static string _Country = Properties.Settings.Default.Country;

        private static int _cityID = 756135;
        private static string _cityName = "Warsaw";
        private static string _APIKey = "2485fdd3fdb1cc76a56e89714cc815ef";
        private static string _units = "metric";
        private static int _refreshInterval = 15;
        private static string _Country = "PL";

        //public static void SaveDefaultValues()
        //{
        //    Properties.Settings.Default.Save();
        //}

        public static int CityID
        {
            get { return _cityID; }
            set {
                _cityID = value;
                //Properties.Settings.Default.CityId = value;
            }
        }

        public static string CityName
        {
            get { return _cityName; }
            set {
                _cityName = value;
                //Properties.Settings.Default.CityName = value;
            }
        }

        public static string Country
        {
            get { return _Country; }
            set {
                _Country = value;
                //Properties.Settings.Default.Country = value;
            }
        }


        public static string APIKey
        {
            get { return _APIKey; }
            set {
                _APIKey = value;
                //Properties.Settings.Default.APIKey = value;
            }
        }

        public static string Units
        {
            get { return _units; }
            set {
                _units = value;
                //Properties.Settings.Default.Units = value;
            }
        }

        public static int RefreshInterval
        {
            get { return _refreshInterval; }
            set {
                _refreshInterval = value;
                //Properties.Settings.Default.RefreshFrequencyMinutes = value;
            }
        }



    }
}
