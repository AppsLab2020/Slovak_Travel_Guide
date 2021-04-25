using Slovak_Travel_Guide.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Slovak_Travel_Guide.Service
{
    class SightsService
    {
        public ObservableCollection<CastlesModel> GetListCastles()
        {
            return new ObservableCollection<CastlesModel>
            {
                new CastlesModel(){MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg",Name="Bratislavský hrad", Latitude=48.142248, Longtitude=17.0996481, IsVisible=false, WebSite="https://sk.wikipedia.org/wiki/Bratislavsk%C3%BD_hrad" },
                new CastlesModel(){MainUrl ="https://slovenskycestovatel.sk/images/items/193/oravsky-hrad47507501.jpg", Name="Oravský hrad", Latitude=49.2737007, Longtitude=19.3521274591451, IsVisible=false, WebSite="https://sk.wikipedia.org/wiki/Oravsk%C3%BD_hrad" },
                new CastlesModel(){MainUrl="https://www.trencinregion.sk/images/listings/37/trenciansky_hrad-6adf3ccbeb02e1fa984b6ba53e30dbf0.jpg", Name="Trenčiansky hrad", Latitude=48.8942001, Longtitude=18.044716600000015, IsVisible=false, WebSite="https://sk.wikipedia.org/wiki/Tren%C4%8Diansky_hrad"}
            };
        }
        public ObservableCollection<CavesModel> GetListCaves()
        {
            return new ObservableCollection<CavesModel>
            {
                new CavesModel(){MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg",Name="Bratislavský hrad", Latitude=48.142248, Longtitude=17.0996481, IsVisible=false, },
            };
        }
        public ObservableCollection<MountainsModel> GetListMountains()
        {
            return new ObservableCollection<MountainsModel>
            {
                new MountainsModel(){MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg",Name="Bratislavský hrad", Latitude=48.142248, Longtitude=17.0996481, IsVisible=false, },

            };
        }
        public ObservableCollection<OldVillagesModel> GetListOldVillages()
        {
            return new ObservableCollection<OldVillagesModel>
            {
                new OldVillagesModel(){MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg",Name="Bratislavský hrad", Latitude=48.142248, Longtitude=17.0996481, IsVisible=false, },

            };
        }
        public ObservableCollection<SkiDestinationsModel> GetListSkiDestinations()
        {
            return new ObservableCollection<SkiDestinationsModel>
            {
                new SkiDestinationsModel(){MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg",Name="Bratislavský hrad", Latitude=48.142248, Longtitude=17.0996481, IsVisible=false, },
            };
        }
        public ObservableCollection<ZoosModel> GetListZoos()
        {
            return new ObservableCollection<ZoosModel>
            {
                new ZoosModel(){MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg",Name="Bratislavský hrad", Latitude=48.142248, Longtitude=17.0996481, IsVisible=false, },
            };
        }
            
            
    }
}
