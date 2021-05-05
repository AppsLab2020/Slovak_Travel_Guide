using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Slovak_Travel_Guide.View;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Slovak_Travel_Guide.ViewModel
{
    class InfoPageViewModel : INotifyPropertyChanged
    {
        public string Url1 { get; set; }
        public string Url2 { get; set; }
        public string Url3 { get; set; }
        public string Url4 { get; set; }
        public string Name { get; set; }
        public string AboutSight { get; set; }
        public string WebSite { get; set; }
        public ICommand ShowWebSite { get; }
        public INavigation Navigation;

        public InfoPageViewModel(INavigation navigation, string webSite, string aboutSight, string name, string url1, string url2, string url3, string url4)
        {
            Navigation = navigation;
            ShowWebSite = new Command(GoToWebSite);
            WebSite = webSite;
            AboutSight = aboutSight;
            Name = name;
            Url1 = url1;
            Url2 = url2;
            Url3 = url3;
            Url4 = url4;
        }

        public async void GoToWebSite()
        {
           await Navigation.PushAsync(new View.WebView(WebSite));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanges([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
