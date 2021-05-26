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
                new CastlesModel(){
                    MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg",
                    Name="Bratislavský hrad", 
                    Latitude=48.142248, 
                    Longtitude=17.0996481, 
                    IsVisible=false, 
                    WebSite="https://sk.wikipedia.org/wiki/Bratislavsk%C3%BD_hrad" },

                new CastlesModel(){
                    MainUrl="https://slovenskycestovatel.sk/images/items/193/oravsky-hrad47507501.jpg", 
                    Name="Oravský hrad", 
                    Latitude=49.2737007, 
                    Longtitude=19.3521274591451, 
                    IsVisible=false, 
                    WebSite="https://sk.wikipedia.org/wiki/Oravsk%C3%BD_hrad" },

                new CastlesModel(){
                    MainUrl="https://www.trencinregion.sk/images/listings/37/trenciansky_hrad-6adf3ccbeb02e1fa984b6ba53e30dbf0.jpg", 
                    Name="Trenčiansky hrad", 
                    Latitude=48.8942001, 
                    Longtitude=18.044716600000015, 
                    IsVisible=false, 
                    WebSite="https://sk.wikipedia.org/wiki/Tren%C4%8Diansky_hrad"},

                new CastlesModel(){
                    MainUrl="https://www.terasybojnice.sk/wp-content/uploads/2020/08/dreamstime_186283861-zamoj-bojnice.jpg", 
                    Name="Bojnícky zámok", 
                    Latitude=48.391050, 
                    Longtitude=17.798090, 
                    IsVisible=false, 
                    WebSite="https://sk.wikipedia.org/wiki/Bojnick%C3%BD_z%C3%A1mok"},

                new CastlesModel(){
                    MainUrl="https://www.zilinak.sk/assets/images/za/posts/img-1/1588527483-video-najnovsie-zabery-z-vysky-na-hrad-strecno-a-rozhladnu-spicak.jpg", 
                    Name="Hrad Strečno", 
                    Latitude=49.183500, 
                    Longtitude=18.863380, 
                    IsVisible=false, 
                    WebSite="https://sk.wikipedia.org/wiki/Stre%C4%8Dno_(hrad)"},

                new CastlesModel(){
                    MainUrl="https://mrtns.eu/tovar/_l/606/l606033.jpg?v=1607139091", 
                    Name="Spišský Hrad", 
                    Latitude=49.000771, 
                    Longtitude=20.753990, 
                    IsVisible=false, 
                    WebSite="https://sk.wikipedia.org/wiki/Spi%C5%A1sk%C3%BD_hrad"}
            };
        }
        public ObservableCollection<CavesModel> GetListCaves()
        {
            return new ObservableCollection<CavesModel>
            {

                new CavesModel(){
                    MainUrl="https://upload.wikimedia.org/wikipedia/commons/3/3f/Demenovska_jaskyna_slobody-smaragdove_jazierko.jpg",
                    Name="Demänovská jaskyňa", 
                    Latitude=48.971600, 
                    Longtitude=19.580730, 
                    IsVisible=false, 
                    WebSite="https://sk.wikipedia.org/wiki/Dem%C3%A4novsk%C3%A1_jasky%C5%88a_slobody", },

                new CavesModel(){
                    MainUrl="https://kamnavyletsk.b-cdn.net/rails/active_storage/representations/redirect/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBdG92IiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--862ad2ee27760d93c5e2f8f2a2afd579d937826d/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaDdDam9MWm05eWJXRjBJZ2xxY0dWbk9oQmhkWFJ2WDI5eWFXVnVkRlE2REdkeVlYWnBkSGxKSWd0alpXNTBaWElHT2daRlZEb0xjbVZ6YVhwbFNTSU5OVFkwZURNeU1GNEdPd2hVT2dsamNtOXdTU0lRTlRZMGVETXlNQ3N3S3pBR093aFUiLCJleHAiOm51bGwsInB1ciI6InZhcmlhdGlvbiJ9fQ==--bf55f18c70caf8845c0152dc19a4f2ea0a4c3289/blob?locale=sk",
                    Name="Mučínska jaskyňa",
                    Latitude=48.876030,
                    Longtitude=20.296630,
                    IsVisible=false,
                    WebSite="https://sk.wikipedia.org/wiki/Dem%C3%A4novsk%C3%A1_jasky%C5%88a_slobody", },

                new CavesModel(){
                    MainUrl="https://www.tikroznava.sk/wp-content/uploads/2018/10/silickaladnica-2.jpg",
                    Name="Silická ľadnica",
                    Latitude=48.532540,
                    Longtitude=20.485660,
                    IsVisible=false,
                    WebSite="https://sk.wikipedia.org/wiki/Silick%C3%A1_%C4%BEadnica", },

                new CavesModel(){
                    MainUrl="https://www.megaubytovanie.sk/images/attractionphotos/0487effa-4841-43e6-9dbb-8d264fdbcc78.jpg",
                    Name="Šarkanova diera",
                    Latitude=51.200990,
                    Longtitude=13.404120,
                    IsVisible=false,
                    WebSite="https://sk.wikipedia.org/wiki/%C5%A0arkanova_diera", },

                new CavesModel(){
                    MainUrl="https://tipnatrip.com/wp-content/uploads/2020/06/Demanovska_Ladova_jaskyna__Jaskyne_na_Slovensku.jpg",
                    Name="Demänovská ľadová jaskyňa",
                    Latitude=48.876030,
                    Longtitude=20.296630,
                    IsVisible=false,
                    WebSite="https://sk.wikipedia.org/wiki/Dem%C3%A4novsk%C3%A1_%C4%BEadov%C3%A1_jasky%C5%88a", },

                new CavesModel(){
                    MainUrl="https://4.bp.blogspot.com/-4cP2BUBtdWw/VSuM0gOgqlI/AAAAAAAAZ2Q/T5l4ReRYTa0/s1600/tn_DSCF1778ok.jpg",
                    Name="Perlová Jaskyňa",
                    Latitude=48.868690,
                    Longtitude=20.965200,
                    IsVisible=false,
                    WebSite="https://sk.wikipedia.org/wiki/Perlov%C3%A1_jasky%C5%88a", },
            };
        }
        public ObservableCollection<MountainsModel> GetListMountains()
        {
            return new ObservableCollection<MountainsModel>
            {
                new MountainsModel(){
                    MainUrl="https://t.aimg.sk/magaziny/V6G-HK4iSjjP2nzSrciJNw.1280~Vysok-Tatry-patria-medzi-naj-miesta-pre-rok-2019.jpg?t=LzB4Mzg6MTI4MHg3NTgvODAweDQ1MC9zbWFydA%3D%3D&h=GqhbKVzDJBfxvOTnTZMJpA&e=2145916800&v=2",
                    Name="Vysoké Tatry", 
                    Latitude=49.139050, 
                    Longtitude=20.220381, 
                    IsVisible=false, 
                    WebSite="https://sk.wikipedia.org/wiki/Vysok%C3%A9_Tatry_(pohorie)", },

                new MountainsModel(){
                    MainUrl="https://www.villaflora.sk/sites/villaflora/files/2018-07/nizke_tatry_dumbier_family_resort_www.villaflora.sk_.jpg",
                    Name="Nízke Tatry",
                    Latitude=49.139050,
                    Longtitude=20.220381,
                    IsVisible=false,
                    WebSite="https://sk.wikipedia.org/wiki/N%C3%ADzke_Tatry", },

                new MountainsModel(){
                    MainUrl="https://www.planetslovakia.sk/images/priroda/kralova-hola-nizke-tatry/190706-19-44-DSC_5046-kralova-hola-nizke-tatry.jpg",
                    Name="Kráľova Hoľa",
                    Latitude=50.450090,
                    Longtitude=16.059080,
                    IsVisible=false,
                    WebSite="https://sk.wikipedia.org/wiki/Kr%C3%A1%C4%BEova_ho%C4%BEa", },

                new MountainsModel(){
                    MainUrl="https://www.terchova.eu/images/stories/velky_krivan.jpg",
                    Name="Kriváň",
                    Latitude=49.1625586,
                    Longtitude=19.9911611,
                    IsVisible=false,
                    WebSite="https://sk.wikipedia.org/wiki/Ve%C4%BEk%C3%BD_Kriv%C3%A1%C5%88", },

                new MountainsModel(){
                    MainUrl="https://www.visitliptov.sk/wp-content/uploads/2019/03/chopok09.jpg",
                    Name="Chopok",
                    Latitude=48.9434057,
                    Longtitude=19.5812725,
                    IsVisible=false,
                    WebSite="https://sk.wikipedia.org/wiki/Ve%C4%BEk%C3%BD_Kriv%C3%A1%C5%88", },

                new MountainsModel(){
                    MainUrl="https://www.terchova.eu/images/stories/turisticke_trasy/vrcholy_malej_fatry/turisticka_trasa_na_maly_rozsutec.jpg",                  
                    Name="Malý Rozsutec",
                    Latitude=49.2464764,
                    Longtitude=19.0928837,
                    IsVisible=false,
                    WebSite="https://sk.wikipedia.org/wiki/Mal%C3%BD_Rozsutec", },

            };
        }
        public ObservableCollection<OldVillagesModel> GetListOldVillages()
        {
            return new ObservableCollection<OldVillagesModel>
            {
                new OldVillagesModel(){
                MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg",
                Name="Jasná", 
                Latitude=48.9672732, 
                Longtitude=19.5831966, 
                IsVisible=false, 
                WebSite="https://www.jasna.sk/"},

                new OldVillagesModel(){
                MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg",
                Name="Vrátna Paseky",
                Latitude=49.2282509,
                Longtitude=19.0338454,
                IsVisible=false,
                WebSite="https://www.jasna.sk/"},

                new OldVillagesModel(){
                MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg",
                Name="Jasná",
                Latitude=48.9672732,
                Longtitude=19.5831966,
                IsVisible=false,
                WebSite="https://www.jasna.sk/"},

                new OldVillagesModel(){
                MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg",
                Name="Jasná",
                Latitude=48.9672732,
                Longtitude=19.5831966,
                IsVisible=false,
                WebSite="https://www.jasna.sk/"},

                new OldVillagesModel(){
                MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg",
                Name="Jasná",
                Latitude=48.9672732,
                Longtitude=19.5831966,
                IsVisible=false,
                WebSite="https://www.jasna.sk/"},

                new OldVillagesModel(){
                MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg",
                Name="Jasná",
                Latitude=48.9672732,
                Longtitude=19.5831966,
                IsVisible=false,
                WebSite="https://www.jasna.sk/"},
            };
        }
        public ObservableCollection<SkiDestinationsModel> GetListSkiDestinations()
        {
            return new ObservableCollection<SkiDestinationsModel>
            {
                new SkiDestinationsModel(){
                MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg",
                Name="Jasná",
                Latitude=48.9672732,
                Longtitude=19.5831966,
                IsVisible=false,
                WebSite="https://www.jasna.sk/"},

                new SkiDestinationsModel(){
                MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg",
                Name="Vrátna Paseky",
                Latitude=49.2282509,
                Longtitude=19.0338454,
                IsVisible=false,
                WebSite="https://www.jasna.sk/"},

                new SkiDestinationsModel(){
                MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg",
                Name="Kubínska Hoľa",
                Latitude=49.2741801,
                Longtitude=19.2595782,
                IsVisible=false,
                WebSite="https://kubinska.sk/"},

                new SkiDestinationsModel(){
                MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg",
                Name="Jasná",
                Latitude=48.9672732,
                Longtitude=19.5831966,
                IsVisible=false,
                WebSite="https://www.jasna.sk/", },

                new SkiDestinationsModel(){
                MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg",
                Name="Jasná",
                Latitude=48.9672732,
                Longtitude=19.5831966,
                IsVisible=false,
                WebSite="https://www.jasna.sk/", },

                new SkiDestinationsModel(){
                MainUrl="https://bratislavskykraj.sk/wp-content/uploads/2020/05/str-38_hrad-696x626.jpg",
                Name="Jasná",
                Latitude=48.9672732,
                Longtitude=19.5831966,
                IsVisible=false,
                WebSite="https://www.jasna.sk/", },

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
