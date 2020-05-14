using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClock.Models
{
    public class RefreshIntervalModel
    {
        private BindableCollection<int> _refreshIntervals;

        public RefreshIntervalModel()
        {
            PopulateIntervals();
        }

        public BindableCollection<int> RefreshIntervals
        {
            get { return _refreshIntervals; }
            private set { _refreshIntervals = value; }
        }

        private void PopulateIntervals()
        {
            RefreshIntervals = new BindableCollection<int>();
            for(int i = 10; i < 65; i+=5)
            {
                RefreshIntervals.Add(i);
            }
        }

    }
}
