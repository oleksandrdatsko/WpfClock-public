using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfClock.Models;

namespace WpfClock.ViewModels
{
    public class clockMainViewModel : Screen
    {
        TimeDateModel timeDateModel = new TimeDateModel();
        public int HourBlock
        {
            get
            {
                return timeDateModel.Hour;
            }
        }

        public int MinuteBlock
        {
            get
            {
                return timeDateModel.Minute;
            }
        }

        public string DateBlock
        {
            get
            {
                return timeDateModel.Date;
            }
        }

        public void CloseClockBtn()
        {
            Application.Current.Shutdown();
        }
    }
}
