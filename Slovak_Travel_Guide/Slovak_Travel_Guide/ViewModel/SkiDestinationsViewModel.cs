using Slovak_Travel_Guide.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slovak_Travel_Guide.ViewModel
{
    class SkiDestinationsViewModel
    {
        public List<SkiDestinations> SkiDestinations { get; set; }

        public SkiDestinationsViewModel()
        {
            SkiDestinations = new SightsService().GetListSkiDestinations();
        }
    }
}
