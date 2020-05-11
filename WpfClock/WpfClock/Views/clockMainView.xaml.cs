using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfClock.Models;

namespace WpfClock.Views
{
    /// <summary>
    /// Interaction logic for clockMainView.xaml
    /// </summary>
    public partial class clockMainView : Window
    {
        public clockMainView()
        {
            InitializeComponent();

            TimeDateModel timeDateModel = new TimeDateModel();

            Storyboard minutes = (Storyboard)minuteHand.FindResource("sbMinuteHand");
            minutes.Begin();
            minutes.Seek(new TimeSpan(0, 0, 0, timeDateModel.Second, 0));

            Storyboard hours = (Storyboard)hourHand.FindResource("sbHourHand");
            hours.Begin();
            hours.Seek(new TimeSpan(0, 0, timeDateModel.Minute, 0, 0));
        }

        private void dragMe(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}
