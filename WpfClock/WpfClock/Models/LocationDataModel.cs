using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OpenWeatherAPI.Models;
using OpenWeatherAPI.Properties;
using Newtonsoft.Json;
using Caliburn.Micro;
using System.Diagnostics;

namespace WpfClock.Models
{
    public class LocationDataModel
    {
        public LocationDataModel()
        {
            LoadLocationList();
        }

        public void LoadLocationList()
        {
            Task.Run(() => LoadLocationListAsync());
        }

        public bool IsLocationListLoaded()
        {
            return LoadLocationListAsync().Status == TaskStatus.RanToCompletion;
        }

        private async Task LoadLocationListAsync()
        {
            LocationListModel.LocationList = await LoadLocationListJsonAsync();
            Debug.WriteLine($"Location list contains : {LocationListModel.LocationList.Count}");
        }

        private async Task<BindableCollection<LocationModel>> LoadLocationListJsonAsync()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string[] fileName = assembly.GetManifestResourceNames();
            using (Stream stream = assembly.GetManifestResourceStream("WpfClock.Resources.city.list.json"))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string json = await reader.ReadToEndAsync();

                    string sortedJson = SortAscJson(json);

                    BindableCollection<LocationModel> CityList = JsonConvert.DeserializeObject<BindableCollection<LocationModel>>(sortedJson);

                    return CityList;
                }
            }

        }

        private string SortAscJson(string json)
        {
            List < LocationModel > myList = JsonConvert.DeserializeObject<List<LocationModel>>(json);
            IEnumerable<LocationModel> sortedJson = myList.OrderBy(x => x.Country).ThenBy(x => x.Name);
            return JsonConvert.SerializeObject(sortedJson);

        }
    }
}
