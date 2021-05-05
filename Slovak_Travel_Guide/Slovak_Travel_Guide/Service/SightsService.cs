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
                new CavesModel(){MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg",Name="Bratislavský hrad", Latitude=48.142248, Longtitude=17.0996481, IsVisible=false, WebSite="https://sk.wikipedia.org/wiki/Bratislavsk%C3%BD_hrad", AboutSight="je to fajny, utekaj tam a uzi si to. A NEZABUDNI SI KUPIT NASU APPKU!!!", Url1="https://www.visitbratislava.com/wp-content/uploads/2014/10/letecka-vychod-slnka-hrad-800x533.jpg", Url2="https://staticcdn.sk/images/photoarchive/sized/700/2016/12/30/Bratislavsky-hrad-4-.jpg", Url3="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg", Url4="https://onlyslovakia.com/wp-content/uploads/bratislava_castle_.hmfxo_.jpg" },
                new CavesModel(){MainUrl="https://upload.wikimedia.org/wikipedia/commons/3/3f/Demenovska_jaskyna_slobody-smaragdove_jazierko.jpg",Name="Demänovská jaskyňa", Latitude=48.971600, Longtitude=19.580730, IsVisible=false, WebSite="https://sk.wikipedia.org/wiki/Dem%C3%A4novsk%C3%A1_jasky%C5%88a_slobody", },

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
