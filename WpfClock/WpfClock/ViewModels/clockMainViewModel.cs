﻿using Caliburn.Micro;
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
using WpfClock.Models;

namespace WpfClock.ViewModels
{
    public class clockMainViewModel : Screen
    {
        private WeatherDataModel _weatherDataModel = new WeatherDataModel();
        private WeatherForecastDataModel _weatherDataForecastModel = new WeatherForecastDataModel();
        private DispatcherTimer _clockRefreshTimer = new DispatcherTimer();
        private DispatcherTimer _weatherDataRefreshTimer = new DispatcherTimer();
        private DispatcherTimer _weatherForecastDataRefreshTimer = new DispatcherTimer();
        private TimeDateModel _timeDateModel = new TimeDateModel();
        private string _minuteBlock;
        private string _hourBlock;
        private string _dateBlock;
        private string _weekDayBlock;
        private BindableCollection<WeatherForecastDataModel> _forecastList;

        public clockMainViewModel()
        {
            _weatherDataModel.LoadCurrentWeatherData();
            _weatherDataForecastModel.LoadWeatherForecastData();
            SetClockTimer();

            _weatherDataModel.WeatherDataReceivedEvent += _weatherDataModel_WeatherDataReceivedEvent;
            _weatherDataForecastModel.WeatherForecastDataReceivedEvent += _weatherDataForecastModel_WeatherForecastDataReceivedEvent;

        }

        #region Event handlers
        private void _weatherDataForecastModel_WeatherForecastDataReceivedEvent(object sender, bool e)
        {
            try
            {
                SetForecastWeatherTimer();
            }
            catch (Exception)
            {

            }
        }

        private void _weatherDataModel_WeatherDataReceivedEvent(object sender, bool e)
        {
            try
            {
                SetCurrentWeatherTimer();
            }
            catch (Exception)
            {

            }
            
        }

        #endregion

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
            _clockRefreshTimer.Interval = TimeSpan.FromSeconds(0.1);
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
        private string _tempHighBlock;
        private string _tempLowBlock;
        private string _humidityBlock;
        private string _windBlock;
        private string _windDirectionBlock;
        private string _lastUpdateBlock;
        private string _currentWeatherName;

        public string LocationBlock
        {
            get { return _locationBlock; }
            set
            {
                _locationBlock = value;
                NotifyOfPropertyChange(() => LocationBlock);
            }
        }

        public string CurrentWeatherName
        {
            get { return _currentWeatherName; }
            set
            {
                _currentWeatherName = value;
                NotifyOfPropertyChange(() => CurrentWeatherName);
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

        public string TempHighBlock
        {
            get { return _tempHighBlock; }
            set
            {
                _tempHighBlock = value;
                NotifyOfPropertyChange(() => TempHighBlock);
            }
        }

        public string TempLowBlock
        {
            get { return _tempLowBlock; }
            set
            {
                _tempLowBlock = value;
                NotifyOfPropertyChange(() => TempLowBlock);
            }
        }

        public string HumidityBlock
        {
            get { return _humidityBlock; }
            set
            {
                _humidityBlock = value;
                NotifyOfPropertyChange(() => HumidityBlock);
            }
        }

        public string WindBlock
        {
            get { return _windBlock; }
            set
            {
                _windBlock = value;
                NotifyOfPropertyChange(() => WindBlock);
            }
        }

        public string WindDirectionBlock
        {
            get { return _windDirectionBlock; }
            set
            {
                _windDirectionBlock = value;
                NotifyOfPropertyChange(() => WindDirectionBlock);
            }
        }

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
            _weatherDataRefreshTimer.Start();
            _weatherDataRefreshTimer.Interval = TimeSpan.FromSeconds(0.1);
            _weatherDataRefreshTimer.Tick += new EventHandler(CurrentWeatherTimerTick);
        }

        private void CurrentWeatherTimerTick(object sender, EventArgs e)
        {
            _weatherDataRefreshTimer.Stop();
            GetCurrentWeather();
        }

        private void GetCurrentWeather()
        {
            LocationBlock = _weatherDataModel.CurrentLocation;
            CurrentWeatherName = _weatherDataModel.CurrentWeatherName;
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

        #region Forecast Weather Region
        public BindableCollection<WeatherForecastDataModel> ForecastList
        {
            get { return _forecastList; }
            set
            {
                _forecastList = value;
                NotifyOfPropertyChange(() => ForecastList);
            }
        }

        private void SetForecastWeatherTimer()
        {
            _weatherForecastDataRefreshTimer.Start();
            _weatherForecastDataRefreshTimer.Interval = TimeSpan.FromSeconds(0.1);
            _weatherForecastDataRefreshTimer.Tick += new EventHandler(ForecastWeatherTimerTick);
        }

        private void ForecastWeatherTimerTick(object sender, EventArgs e)
        {
            _weatherForecastDataRefreshTimer.Stop();
            GetForecastWeather();
        }

        private void GetForecastWeather()
        {
            ForecastList = _weatherDataForecastModel.ForecastData;
        }

        #endregion

        #region Buttons
        public void CloseClockBtn()
        {
            Application.Current.Shutdown();
        }
        #endregion

    }
}
