using Slovak_Travel_Guide.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slovak_Travel_Guide.ViewModel
{
    class OldVillagesViewModel
    {
        public List<OldVillages> OldVillages { get; set; }

        public OldVillagesViewModel()
        {
            OldVillages = new SightsService().GetListOldVillages();
        }
    }
}
