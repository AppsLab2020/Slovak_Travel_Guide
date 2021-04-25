using System;
using System.Collections.Generic;
using System.Text;

namespace Slovak_Travel_Guide.Model
{
    class SkiDestinationsModel
    {
        public string Name { get; set; }
        public string MainUrl { get; set; }
        public double Latitude { get; set; }
        public double Longtitude { get; set; }
        public bool IsVisible { get; set; }
        public string WebSite { get; set; }
    }
}
