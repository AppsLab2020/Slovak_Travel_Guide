
using Slovak_Travel_Guide.Model;
using Slovak_Travel_Guide.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Slovak_Travel_Guide.ViewModel
{
    class CastlesViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<CastlesModel> Castles { get; set; }
        public ICommand BtnNavigate { get; set; }
        public ICommand SelectionChangedCommand { get; set; }
        public ICommand BtnInfo { get; set; }
        public ICommand BtnWeather { get; set; }
        private CastlesModel selectionChangedCommandParameter { get; set; }
        private CastlesModel _oldCastle;
        public CastlesViewModel()
        {
            Castles = new SightsService().GetListCastles();
            BtnNavigate = new Command(NavigateToSight);
            BtnInfo = new Command(GoToWebSite);
            BtnWeather = new Command(ShowWeather);
        }

        public void FillCommandGPS(CastlesModel castle)
        {
            selectionChangedCommandParameter = castle;
        }

        public void HideOrShowCastles(CastlesModel castle)
        {
            if (_oldCastle == castle)
            {
                castle.IsVisible = !castle.IsVisible;
                UpdateCastles(castle);
            }
            else
            {
                if (_oldCastle != null)
                {
                    _oldCastle.IsVisible = false;
                    UpdateCastles(_oldCastle);
                }
                castle.IsVisible = true;
                UpdateCastles(castle);
            }
            _oldCastle = castle;
        }
        private void UpdateCastles(CastlesModel castle)
        {
            var index = Castles.IndexOf(castle);
            Castles.Remove(castle);
            Castles.Insert(index, castle);
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
            Device.OpenUri(new Uri(selectionChangedCommandParameter.WebSite));
        }
        public async void ShowWeather()
        {
            App.Current.MainPage.DisplayAlert("Weather", "Noooooo, pjekný počasíčko dnes máme. Utekaj to rýchlo využiť!", "Okáčko");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanges([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
