﻿using Slovak_Travel_Guide.Model;
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
                new CastlesModel(){MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg", AboutSight="Jop more pjekny to je id tam a neotravuj",Name="Bratislavsky hrad", SecondUrl="https://turisticky.sk/wp-content/uploads/2020/01/Bratislavsky-hrad_SS_02-scaled.jpg", ThirdUrl="https://turisticky.sk/wp-content/uploads/2020/01/Bratislavsky-hrad_SS_02-scaled.jpg", LatitudeAndLongtitude=new List<double>{48.142248, 17.0996481}, }

            };
        }
        public ObservableCollection<CavesModel> GetListCaves()
        {
            return new ObservableCollection<CavesModel>
            {
                new CavesModel(){MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg", AboutSight="Jop more pjekny to je id tam a neotravuj",Name="Bratislavský hrad", SecondUrl="https://turisticky.sk/wp-content/uploads/2020/01/Bratislavsky-hrad_SS_02-scaled.jpg", ThirdUrl="https://turisticky.sk/wp-content/uploads/2020/01/Bratislavsky-hrad_SS_02-scaled.jpg", Latitude=48.142248, Longtitude=17.0996481, IsVisible=false, },
                new CavesModel(){MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg", AboutSight="Jop more pjekny to je id tam a neotravuj",Name="Bratislavský hrad", SecondUrl="https://turisticky.sk/wp-content/uploads/2020/01/Bratislavsky-hrad_SS_02-scaled.jpg", ThirdUrl="https://turisticky.sk/wp-content/uploads/2020/01/Bratislavsky-hrad_SS_02-scaled.jpg", Latitude=48.142248, Longtitude=17.0996481, IsVisible=false, }
            };
        }
        public List<MountainsModel> GetListMountains()
        {
            return new List<MountainsModel>
            {
                new MountainsModel(){MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg", AboutSight="Jop more pjekny to je id tam a neotravuj",Name="Bratislavsky hrad", SecondUrl="https://turisticky.sk/wp-content/uploads/2020/01/Bratislavsky-hrad_SS_02-scaled.jpg", ThirdUrl="https://turisticky.sk/wp-content/uploads/2020/01/Bratislavsky-hrad_SS_02-scaled.jpg", LatitudeAndLongtitude=new List<double>{48.142248, 17.0996481}, }

            };
        }
        public List<OldVillagesModel> GetListOldVillages()
        {
            return new List<OldVillagesModel>
            {
                new OldVillagesModel(){MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg", AboutSight="Jop more pjekny to je id tam a neotravuj",Name="Bratislavsky hrad", SecondUrl="https://turisticky.sk/wp-content/uploads/2020/01/Bratislavsky-hrad_SS_02-scaled.jpg", ThirdUrl="https://turisticky.sk/wp-content/uploads/2020/01/Bratislavsky-hrad_SS_02-scaled.jpg", LatitudeAndLongtitude=new List<double>{48.142248, 17.0996481}, }

            };
        }
        public List<SkiDestinationsModel> GetListSkiDestinations()
        {
            return new List<SkiDestinationsModel>
            {
                new SkiDestinationsModel(){MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg", AboutSight="Jop more pjekny to je id tam a neotravuj",Name="Bratislavsky hrad", SecondUrl="https://turisticky.sk/wp-content/uploads/2020/01/Bratislavsky-hrad_SS_02-scaled.jpg", ThirdUrl="https://turisticky.sk/wp-content/uploads/2020/01/Bratislavsky-hrad_SS_02-scaled.jpg", LatitudeAndLongtitude=new List<double>{48.142248, 17.0996481},}
            };
        }
        public List<ZoosModel> GetListZoos()
        {
            return new List<ZoosModel>
            {
                new ZoosModel(){MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg", AboutSight="Jop more pjekny to je id tam a neotravuj",Name="Bratislavsky hrad", SecondUrl="https://turisticky.sk/wp-content/uploads/2020/01/Bratislavsky-hrad_SS_02-scaled.jpg", ThirdUrl="https://turisticky.sk/wp-content/uploads/2020/01/Bratislavsky-hrad_SS_02-scaled.jpg", LatitudeAndLongtitude=new List<double>{48.142248, 17.0996481},}
            };
        }
            
            
    }
}
