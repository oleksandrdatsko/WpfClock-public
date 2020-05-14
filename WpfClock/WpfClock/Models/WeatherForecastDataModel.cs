using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenWeatherAPI.Models;
using OpenWeatherAPI.API;
using System.Windows;
using WpfClock.Models;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Caliburn.Micro;

namespace WpfClock.Models
{
    public class WeatherForecastDataModel
    {

        private WeatherForecastModel _weatherForecastData;
        private WeatherDataTransformationModel _weatherDataTransformation = new WeatherDataTransformationModel();
        private BindableCollection<WeatherForecastDataModel> _weatherForecastDataList = new BindableCollection<WeatherForecastDataModel>();

        public event EventHandler<bool> WeatherForecastDataReceivedEvent;

        private async Task<WeatherForecastModel> LoadWeatherForecast()
        {
            string url = GetURL();
            WeatherForecastModel response = new WeatherForecastModel();
            try
            {
                response = await APIProcessor<WeatherForecastModel>.APICall(url);

            }
            catch (Exception e)
            {
                response = await APIProcessor<WeatherForecastModel>.APICall(url);
                MessageBox.Show("Error while loading weather data. Server response: " + e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return response;

        }

        private string GetURL()
        {
            if (DefaultValuesModel.APIKey != "")
            {
                return $"http://api.openweathermap.org/data/2.5/forecast?id={ DefaultValuesModel.CityID }&appid={ DefaultValuesModel.APIKey }&units={ DefaultValuesModel.Units }&cnt=8";
            }
            else
            {
                return GetDefaultURL();
            }
        }

        private string GetDefaultURL()
        {
            return "https://samples.openweathermap.org/data/2.5/find?lat=57&lon=-2.15&cnt=3&appid=439d4b804bc8187953eb36d2a8c26a02";
        }

        public void LoadWeatherForecastData()
        {
            Task.Run(() => GetData());
        }

        private async Task GetData()
        {
            _weatherForecastData = await LoadWeatherForecast();

            for(int i = 0; i < _weatherForecastData.list.Count; i++ )
            {
                WeatherForecastDataModel tmp = new WeatherForecastDataModel();
                tmp.Dt = _weatherForecastData.list[i].Dt;
                tmp.MainTemp = _weatherForecastData.list[i].main.Temp;
                tmp.MainTempMax = _weatherForecastData.list[i].main.Temp_max;
                tmp.MainTempMin = _weatherForecastData.list[i].main.Temp_min;
                tmp.WeatherDescription = _weatherForecastData.list[i].weather[0].Description.ToUpper();
                tmp.WeatherIcon = _weatherForecastData.list[i].weather[0].Icon;
                _weatherForecastDataList.Add(tmp);
            }

            WeatherForecastDataReceivedEvent?.Invoke(this, true);
        }

        #region Weather Forecast properties
        private int _cnt;
        private int _dt;
        private double _mainTemp;
        private double _mainTempMin;
        private double _mainTempMax;
        private string _weatherDescription;
        private string _weatherIcon;

        public int Cnt
        {
            get { return _cnt; }
            set { _cnt = value; }
        }

        public int Dt
        {
            get { return _dt; }
            set { _dt = value; }
        }

        public double MainTemp
        {
            get { return _mainTemp; }
            set { _mainTemp = value; }
        }

        public double MainTempMin
        {
            get { return _mainTempMin; }
            set { _mainTempMin = value; }
        }

        public double MainTempMax
        {
            get { return _mainTempMax; }
            set { _mainTempMax = value; }
        }
        public string WeatherDescription
        {
            get { return _weatherDescription; }
            set { _weatherDescription = value; }
        }

        public string WeatherIcon
        {
            get { return _weatherIcon; }
            set { _weatherIcon = value; }
        }

        #endregion


        #region View properties

        public string ForecastDate
        {
            get { return _weatherDataTransformation.GetDateTodayTomorrowFromUnix(Dt).ToString(); }
        }

        public string CurrentTemp
        {
            get { return _weatherDataTransformation.FormatTemperatureCelsicus(MainTemp); }
        }

        public string TempHighVal
        {
            get { return _weatherDataTransformation.FormatTemperatureCelsicus(MainTempMax); }
        }

        public string TempLowVal
        {
            get { return _weatherDataTransformation.FormatTemperatureCelsicus(MainTempMin); }
        }

        public string CurrentWeatherName
        {
            get { return $"{ WeatherDescription }"; }
        }

        public ImageSource CurrentWeatherImg
        {
            get { return new BitmapImage(new Uri(_weatherDataTransformation.GetImageUrl(WeatherIcon), UriKind.Absolute)); }
        }

        public BindableCollection<WeatherForecastDataModel> ForecastData
        {
            get { return _weatherForecastDataList;  }
        }

        #endregion

    }
}
