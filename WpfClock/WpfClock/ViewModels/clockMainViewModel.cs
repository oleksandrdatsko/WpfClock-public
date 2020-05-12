using Caliburn.Micro;
using OpenWeatherAPI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using WeatherApp.Models;
using WpfClock.Models;

namespace WpfClock.ViewModels
{
    public class clockMainViewModel : Screen
    {
        private WeatherDataModel _weatherDataModel = new WeatherDataModel();
        private DispatcherTimer _clockRefreshTimer = new DispatcherTimer();
        private TimeDateModel _timeDateModel = new TimeDateModel();
        private string _minuteBlock;
        private string _hourBlock;
        private string _dateBlock;
        private string _weekDayBlock;

        public clockMainViewModel()
        {
            _weatherDataModel.LoadCurrentWeatherData();
            SetCurrentWeatherTimer();
            SetClockTimer();
        }

        #region Clock Properties
        public string HourBlock
        {
            get
            {
                return _hourBlock;
            }
            set
            {
                _hourBlock = value;
                NotifyOfPropertyChange(() => HourBlock);
            }
        }

        public string MinuteBlock
        {
            get
            {
                return _minuteBlock;
            }
            set
            {
                _minuteBlock = value;
                NotifyOfPropertyChange(() => MinuteBlock);
            }
        }

        public string DateBlock
        {
            get
            {
                return _dateBlock;
            }
            set
            {
                _dateBlock = value;
                NotifyOfPropertyChange(() => DateBlock);
            }
        }

        public string WeekDayBlock
        {
            get
            {
                return _weekDayBlock;
            }
            set
            {
                _weekDayBlock = value;
                NotifyOfPropertyChange(() => WeekDayBlock);
            }
        }

        private void SetClockTimer()
        {
            _clockRefreshTimer.Start();
            _clockRefreshTimer.Interval = TimeSpan.FromSeconds(0.5);
            _clockRefreshTimer.Tick += new EventHandler(ClockTimerTick);
        }

        private void ClockTimerTick(object sender, EventArgs e)
        {
            GetTime();
        }

        private void GetTime()
        {
            _timeDateModel.setDate();
            HourBlock = _timeDateModel.HourStr;
            MinuteBlock = _timeDateModel.MinuteStr;
            DateBlock = _timeDateModel.Date;
            WeekDayBlock = _timeDateModel.WeekDay;
        }
        #endregion


        #region Current Weather Properties

        private string _locationBlock;
        private ImageSource _currentWeatherImage;
        private string _temperatureBlock;

        public string LocationBlock
        {
            get { return _locationBlock; }
            set
            {
                _locationBlock = value;
                NotifyOfPropertyChange(() => LocationBlock);
            }
        }

        public ImageSource CurrentWeatherImage
        {
            get { return _currentWeatherImage; }
            set
            {
                _currentWeatherImage = value;
                NotifyOfPropertyChange(() => CurrentWeatherImage);
            }
        }

        public string TemperatureBlock
        {
            get { return _temperatureBlock; }
            set
            {
                _temperatureBlock = value;
                NotifyOfPropertyChange(() => TemperatureBlock);
            }
        }

        private string _tempHighBlock;

        public string TempHighBlock
        {
            get { return _tempHighBlock; }
            set
            {
                _tempHighBlock = value;
                NotifyOfPropertyChange(() => TempHighBlock);
            }
        }

        private string _tempLowBlock;

        public string TempLowBlock
        {
            get { return _tempLowBlock; }
            set
            {
                _tempLowBlock = value;
                NotifyOfPropertyChange(() => TempLowBlock);
            }
        }

        private string _humidityBlock;

        public string HumidityBlock
        {
            get { return _humidityBlock; }
            set
            {
                _humidityBlock = value;
                NotifyOfPropertyChange(() => HumidityBlock);
            }
        }

        private string _windBlock;

        public string WindBlock
        {
            get { return _windBlock; }
            set
            {
                _windBlock = value;
                NotifyOfPropertyChange(() => WindBlock);
            }
        }

        private string _windDirectionBlock;

        public string WindDirectionBlock
        {
            get { return _windDirectionBlock; }
            set
            {
                _windDirectionBlock = value;
                NotifyOfPropertyChange(() => WindDirectionBlock);
            }
        }

        private string _lastUpdateBlock;

        public string LastUpdateBlock
        {
            get { return _lastUpdateBlock; }
            set
            {
                _lastUpdateBlock = value;
                NotifyOfPropertyChange(() => LastUpdateBlock);
            }
        }


        private void SetCurrentWeatherTimer()
        {
            _clockRefreshTimer.Start();
            _clockRefreshTimer.Interval = TimeSpan.FromSeconds(1);
            _clockRefreshTimer.Tick += new EventHandler(CurrentWeatherTimerTick);
        }

        private void CurrentWeatherTimerTick(object sender, EventArgs e)
        {
            GetCurrentWeather();
        }

        private void GetCurrentWeather()
        {
            LocationBlock = _weatherDataModel.CurrentLocation;
            CurrentWeatherImage = _weatherDataModel.CurrentWeatherImg;
            TemperatureBlock = _weatherDataModel.CurrentTemp;
            TempHighBlock = _weatherDataModel.TempHighVal;
            TempLowBlock = _weatherDataModel.TempLowVal;
            HumidityBlock = _weatherDataModel.CurrentHumidityVal;
            WindBlock = _weatherDataModel.CurrentWindVal;
            WindDirectionBlock = _weatherDataModel.CurrentWindDirectionVal;
            LastUpdateBlock = _weatherDataModel.LastRefreshTimeStamp;
        }


        #endregion

        public void CloseClockBtn()
        {
            Application.Current.Shutdown();
        }

    }
}
