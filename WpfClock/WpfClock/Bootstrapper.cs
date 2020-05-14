using Caliburn.Micro;
using OpenWeatherAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfClock.Models;
using WpfClock.ViewModels;

namespace WpfClock
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
            APIHelper.InitializeClient();
            LocationDataModel GetLocationList = new LocationDataModel();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<clockMainViewModel>();
        }
    }
}
