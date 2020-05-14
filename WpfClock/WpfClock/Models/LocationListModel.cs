using Caliburn.Micro;
using OpenWeatherAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClock.Models
{
    public static class LocationListModel
    {
        private static BindableCollection<LocationModel> _locationList;

        public static event PropertyChangedEventHandler StaticPropertyChanged;
        private static void OnStaticPropertyChanged(string propertyName = "LocationList")
        {
            var handler = StaticPropertyChanged;
            if(handler != null)
            {
                handler(null, new PropertyChangedEventArgs("LocationList"));
            }
        }

        public static BindableCollection<LocationModel> LocationList
        {
            get { return _locationList; }
            set
            {
                _locationList = value;
                OnStaticPropertyChanged("LocationList");
            }
        }

    }
}
