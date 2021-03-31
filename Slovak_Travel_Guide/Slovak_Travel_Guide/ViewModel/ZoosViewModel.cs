using Slovak_Travel_Guide.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slovak_Travel_Guide.ViewModel
{
    class ZoosViewModel
    {
        public List<Zoos> Zoos { get; set; }

        public ZoosViewModel()
        {
            Zoos = new SightsService().GetListZoos();
        }
    }
}
