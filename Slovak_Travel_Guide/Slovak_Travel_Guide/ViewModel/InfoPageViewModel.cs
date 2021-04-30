using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Slovak_Travel_Guide.ViewModel
{
    class InfoPageViewModel
    {
        public string Url1 { get; set; }
        public string Url2 { get; set; }
        public string Url3 { get; set; }
        public string Url4 { get; set; }
        public string Name { get; set; }
        public string AboutSight { get; set; }
        public string WebSite { get; set; }
        public ICommand ShowWebSite;
        public ICommand PreviousPage;
        public INavigation Navigation;

        public InfoPageViewModel(INavigation navigation, string webSite)
        {
            Navigation = navigation;
            ShowWebSite = new Command(GoToWebSite);
            WebSite = webSite;
        }

        public async void GoToWebSite()
        {
            Device.OpenUri(new Uri(WebSite));
        }

    }
}
