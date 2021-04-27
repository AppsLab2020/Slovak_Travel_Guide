using System;
using System.Collections.Generic;
using System.Text;

namespace Slovak_Travel_Guide.Model
{
    class WeatherInfo
    {
        public int Temperature { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
    }
}
