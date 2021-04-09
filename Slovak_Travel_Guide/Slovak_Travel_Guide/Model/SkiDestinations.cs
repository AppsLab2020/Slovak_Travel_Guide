using System;
using System.Collections.Generic;
using System.Text;

namespace Slovak_Travel_Guide.Model
{
    class SkiDestinations
    {
        public string Name { get; set; }
        public string AboutSight { get; set; }
        public string MainUrl { get; set; }
        public string SecondUrl { get; set; }
        public string ThirdUrl { get; set; }
        public List<double> LatitudeAndLongtitude { get; set; }
    }
}
