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

        private string _hourStr;
        private string _minuteStr;
        private string _secondStr;
        private int _hourInt;
        private int _minuteInt;
        private int _secondInt;
        private string _date;
        private string _weekDay;

        public string HourStr
        {
            get
            {
                return _hourStr;
            }
            set
            {
                _hourStr = value;
            }
        }

        public string MinuteStr
        {
            get
            {
                return _minuteStr;
            }
            set
            {
                _minuteStr = value;
            }
        }

        public string SecondStr
        {
            get
            {
                return _secondStr;
            }
            set
            {
                _secondStr = value;
            }
        }

        public int HourInt
        {
            get
            {
                return _hourInt;
            }
            set
            {
                _hourInt = value;
            }
        }

        public int MinuteInt
        {
            get
            {
                return _minuteInt;
            }
            set
            {
                _minuteInt = value;
            }
        }

        public int SecondInt
        {
            get
            {
                return _secondInt;
            }
            set
            {
                _secondInt = value;
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
            HourStr = timeHH(dateTime);
            MinuteStr = timeMM(dateTime);
            SecondStr = timeSS(dateTime);
            HourInt = dateTime.Hour;
            MinuteInt = dateTime.Minute;
            SecondInt = dateTime.Second;
            Date = dateMMMdd(dateTime);
            WeekDay = dateDDDD(dateTime);
        }

        private string timeHH(DateTime dt)
        {
            return string.Format("{0:HH}", dt);
        }

        private string timeMM(DateTime dt)
        {
            return string.Format("{0:mm}", dt);
        }

        private string timeSS(DateTime dt)
        {
            return string.Format("{0:SS}", dt);
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
