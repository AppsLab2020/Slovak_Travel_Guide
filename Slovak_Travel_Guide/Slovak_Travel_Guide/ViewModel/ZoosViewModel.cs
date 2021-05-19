using Slovak_Travel_Guide.Model;
using Slovak_Travel_Guide.Service;
using Slovak_Travel_Guide.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Slovak_Travel_Guide.ViewModel
{
    class ZoosViewModel : INotifyPropertyChanged
    {
        INavigation Navigation { get; set; }
        public ObservableCollection<ZoosModel> Zoos { get; set; }
        public ICommand BtnNavigate { get; set; }
        public ICommand BtnWeather { get; set; }
        public ICommand BtnInfo { get; set; }
        private ZoosModel selectionChangedCommandParameter { get; set; }
        private ZoosModel _oldZoo;

        public ZoosViewModel(INavigation navigation)
        {
            Navigation = navigation;
            Zoos = new SightsService().GetListZoos();
            BtnNavigate = new Command(NavigateToSight);
            BtnInfo = new Command(GoToWebSite);
            BtnWeather = new Command(async () => await ShowWeather());
        }
        public void FillCommandGPS(ZoosModel zoo)
        {
            selectionChangedCommandParameter = zoo;
        }
        public void HideOrShowZoos(ZoosModel zoo)
        {
            if (_oldZoo == zoo)
            {
                zoo.IsVisible = !zoo.IsVisible;
                UpdateZoos(zoo);
            }
            else
            {
                if (_oldZoo != null)
                {
                    _oldZoo.IsVisible = false;
                    UpdateZoos(_oldZoo);
                }
                zoo.IsVisible = true;
                UpdateZoos(zoo);
            }
            _oldZoo = zoo;
        }
        private void UpdateZoos(ZoosModel zoo)
        {
            var index = Zoos.IndexOf(zoo);
            Zoos.Remove(zoo);
            Zoos.Insert(index, zoo);
        }
        public async void NavigateToSight()
        {
            await Map.OpenAsync(selectionChangedCommandParameter.Latitude, selectionChangedCommandParameter.Longtitude, new MapLaunchOptions
            {
                NavigationMode = NavigationMode.Driving,
            });
        }
        public async void GoToWebSite()
        {
            Navigation.PushAsync(new InfoPage(
                            selectionChangedCommandParameter.WebSite,
                            selectionChangedCommandParameter.AboutSight,
                            selectionChangedCommandParameter.Name,
                            selectionChangedCommandParameter.Url1,
                            selectionChangedCommandParameter.Url2,
                            selectionChangedCommandParameter.Url3,
                            selectionChangedCommandParameter.Url4));
        }
        public async Task ShowWeather()
        {
            await Navigation.PushAsync(new Weather(selectionChangedCommandParameter.Latitude, selectionChangedCommandParameter.Longtitude, selectionChangedCommandParameter.Name));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanges([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
