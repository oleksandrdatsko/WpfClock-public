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
            _dateTimeNow = DateTime.Now;
        }

        private DateTime _dateTimeNow;


        public int Hour
        {
            get { return _dateTimeNow.Hour; }
        }

        public int Minute
        {
            get { return _dateTimeNow.Minute; }
        }

        public int Second
        {
            get { return _dateTimeNow.Second; }
        }

        public string Date
        {
            get { return dateMMMdd(); }
        }

        private string dateMMMdd ()
        {
            return string.Format("{0:MMM, dd}", DateTime.Today);
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
