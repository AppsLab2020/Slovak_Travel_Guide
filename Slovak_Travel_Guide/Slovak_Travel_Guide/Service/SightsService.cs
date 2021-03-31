using Slovak_Travel_Guide.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slovak_Travel_Guide.Service
{
    class SightsService
    {
        public List<Castles> GetListCastles()
        {
            return new List<Castles>
            {
                new Castles(){MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg", AboutSight="Jop more pjekny to je id tam a neotravuj",Name="Bratislavsky hrad", SecondUrl="https://turisticky.sk/wp-content/uploads/2020/01/Bratislavsky-hrad_SS_02-scaled.jpg", ThirdUrl="https://turisticky.sk/wp-content/uploads/2020/01/Bratislavsky-hrad_SS_02-scaled.jpg", LatitudeAndLongtitude=new List<double>{48.142248, 17.0996481}, }

            };
        }
        public List<Caves> GetListCaves()
        {
            return new List<Caves>
            {

            };
        }
        public List<Mountains> GetListMountains()
        {
            return new List<Mountains>
            {
            };
        }
        public List<OldVillages> GetListOldVillages()
        {
            return new List<OldVillages>
            {

            };
        }
        public List<SkiDestinations> GetListSkiDestinations()
        {
            return new List<SkiDestinations>
            {

            };
        }
        public List<Zoos> GetListZoos()
        {
            return new List<Zoos>
            {

            };
        }
            
            
    }
}
