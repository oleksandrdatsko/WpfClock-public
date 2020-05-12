using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WpfClock.Models
{
    public class TimeDateModel
    {
        public TimeDateModel()
        {
            setDate();
        }

        private int _hour;
        private int _minute;
        private int _second;
        private string _date;
        private string _weekDay;

        public int Hour
        {
            get
            {
                return _hour;
            }
            set
            {
                _hour = value;
            }
        }

        public int Minute
        {
            get
            {
                return _minute;
            }
            set
            {
                _minute = value;
            }
        }

        public int Second
        {
            get
            {
                return _second;
            }
            set
            {
                _second = value;
            }
        }

        public string Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }

        public string WeekDay
        {
            get
            {
                return _weekDay;
            }
            set
            {
                _weekDay = value;
            }
        }

        public void setDate()
        {
            DateTime dateTime = DateTime.Now;
            Hour = dateTime.Hour;
            Minute = dateTime.Minute;
            Second = dateTime.Second;
            Date = dateMMMdd(dateTime);
            WeekDay = dateDDDD(dateTime);
        }

        private string dateMMMdd (DateTime dt)
        {
            return string.Format("{0:MMM, dd}", dt);
        }

        private string dateDDDD (DateTime dt)
        {
            return string.Format("{0:dddd}", dt);
        }

        private string getDateSuffix (int date)
        {
            string dateStr = date.ToString();
            if(date % 10 == 1 && date != 11)
            {
                return dateStr + "st";
            }
            else if(date % 10 == 2 && date != 12)
            {
                return dateStr + "nd";
            }
            else if (date % 10 == 3 && date != 13)
            {
                return dateStr + "rd";
            }
            else
            {
                return dateStr + "th";
            }
        }


    }
}
