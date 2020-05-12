using OpenWeatherAPI.API;
using OpenWeatherAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WeatherApp.Models
{
    public class WeatherDataModel
    {
        private WeatherDataModel _weatherDataModel = new WeatherDataModel();
        private WeatherModel _weatherData;
        private WeatherDataTransformationModel _weatherDataTransformation = new WeatherDataTransformationModel();

        public async Task<WeatherModel> LoadWeather()
        {
            string url = GetURL();
            WeatherModel response = new WeatherModel();
            try
            {
                response = await APIProcessor<WeatherModel>.APICall(url);
                
            }
            catch (Exception e)
            {
                response = await APIProcessor<WeatherModel>.APICall(GetDefaultURL());
                MessageBox.Show("Error while loading weather data. Server response: " + e.Message,"Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }

            return response;


        }

        private string GetURL()
        {
            //if (DefaultValuesModel.APIKey != "")
            //{
            //    return $"http://api.openweathermap.org/data/2.5/weather?id={ DefaultValuesModel.CityID }&appid={ DefaultValuesModel.APIKey }&units={ DefaultValuesModel.Units }";
            //}
            //else
            //{
                return GetDefaultURL();
            //}
        }

        private string GetDefaultURL()
        {
            return "https://samples.openweathermap.org/data/2.5/weather?id=2172797&appid=b6907d289e10d714a6e88b30761fae22";
        }

        public void LoadCurrentWeatherData()
        {
            Task.Run(() => GetData());
        }

        private async Task GetData()
        {
            _weatherData = await LoadWeather();

            Name = _weatherData.Name;
            SysCountry = _weatherData.sys.Country;
            Dt = _weatherData.Dt;
            MainTemp = _weatherData.main.Temp;
            MainTempMax = _weatherData.main.Temp_max;
            MainTempMin = _weatherData.main.Temp_min;
            MainHumidity = _weatherData.main.Humidity;
            WindSpeed = _weatherData.wind.Speed;
            WindDeg = _weatherData.wind.Deg;
            WeatherDescription = _weatherData.weather[0].Description.ToUpper();
            WeatherIcon = _weatherData.weather[0].Icon;
        }

        #region Weather Properties from WeatherModel
        private string _weatherDescription;
        private string _weatherIcon;
        private double _mainTemp;
        private double _mainPressure;
        private double _mainHumidity;
        private double _mainTempMax;
        private double _mainTempMin;
        private double _windSpeed;
        private double _windDeg;
        private string _sysCountry;
        private int _dt;
        private int _id;
        private string _name;

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

        public double MainTemp
        {
            get { return _mainTemp; }
            set { _mainTemp = value; }
        }

        public double MainPressure
        {
            get { return _mainPressure; }
            set { _mainPressure = value; }
        }

        public double MainHumidity
        {
            get { return _mainHumidity; }
            set { _mainHumidity = value; }
        }

        public double MainTempMax
        {
            get { return _mainTempMax; }
            set
            { _mainTempMax = value; }
        }

        public double MainTempMin
        {
            get { return _mainTempMin; }
            set { _mainTempMin = value; }
        }

        public double WindSpeed
        {
            get { return _windSpeed; }
            set { _windSpeed = value; }
        }

        public double WindDeg
        {
            get { return _windDeg; }
            set { _windDeg = value; }
        }

        public string SysCountry
        {
            get { return _sysCountry; }
            set { _sysCountry = value; }
        }

        public int Dt
        {
            get { return _dt; }
            set { _dt = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        #endregion

        #region View Properties
        public string CurrentLocation
        {
            get { return Name != "Error" ? $"{ Name }, { SysCountry }" : $"{ Name } - { SysCountry }"; }
        }

        public string LastRefreshTimeStamp
        {
            get { return _weatherDataTransformation.GetFullDateFromUnix(Dt).ToString(); }
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

        public string CurrentHumidityVal
        {
            get { return _weatherDataTransformation.FormatHumidity(MainHumidity); }
        }

        public string CurrentWindVal
        {
            get { return _weatherDataTransformation.FormatWindSpeedMetric(WindSpeed); }
        }

        public string CurrentWindDirectionVal
        {
            get { return _weatherDataTransformation.GetWindCompassDirection(WindDeg); }
        }

        public string CurrentWeatherName
        {
            get { return $"{ WeatherDescription }"; }
        }

        public ImageSource CurrentWeatherImg
        {
            get { return new BitmapImage(new Uri(_weatherDataTransformation.GetImageUrl(WeatherIcon), UriKind.Absolute)); }
        }

        #endregion
    }


}
