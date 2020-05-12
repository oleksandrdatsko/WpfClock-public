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

        public void CloseClockBtn()
        {
            Application.Current.Shutdown();
        }

    }
}
