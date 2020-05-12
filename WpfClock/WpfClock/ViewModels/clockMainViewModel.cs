using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using WpfClock.Models;

namespace WpfClock.ViewModels
{
    public class clockMainViewModel : Screen
    {
        private DispatcherTimer _clockRefreshTimer = new DispatcherTimer();
        private TimeDateModel _timeDateModel = new TimeDateModel();
        private int _minuteBlock;
        private int _hourBlock;
        private string _dateBlock;
        private string _weekDayBlock;

        public clockMainViewModel()
        {
            SetClockTimer();
        }

        public int HourBlock
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

        public int MinuteBlock
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

        public void CloseClockBtn()
        {
            Application.Current.Shutdown();
        }

        private void SetClockTimer()
        {
            _clockRefreshTimer.Start();
            _clockRefreshTimer.Interval = TimeSpan.FromSeconds(0.5);
            _clockRefreshTimer.Tick += new EventHandler(timer_Tick);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            getTime();
        }

        private void getTime()
        {
            _timeDateModel.setDate();
            HourBlock = _timeDateModel.Hour;
            MinuteBlock = _timeDateModel.Minute;
            DateBlock = _timeDateModel.Date;
            WeekDayBlock = _timeDateModel.WeekDay;
        }

    }
}
