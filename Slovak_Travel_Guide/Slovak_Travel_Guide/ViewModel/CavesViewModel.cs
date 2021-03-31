using Slovak_Travel_Guide.Model;
using Slovak_Travel_Guide.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slovak_Travel_Guide.ViewModel
{
    class CavesViewModel
    {
        public List<Caves> Caves { get; set; }

        public CavesViewModel()
        {
            Caves = new SightsService().GetListCaves();
        }
    }
}
