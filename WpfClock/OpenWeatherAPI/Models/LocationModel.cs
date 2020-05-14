using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Configuration;

namespace OpenWeatherAPI.Models
{
    public class LocationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public string FullLocation
        {
            get { return $"{ Name }, { Country } - { Id }"; }
        }

    }
}
