using Slovak_Travel_Guide.Model;
using Slovak_Travel_Guide.Service;
using Slovak_Travel_Guide.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Slovak_Travel_Guide.ViewModel
{
    class CavesViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<CavesModel> Caves { get; set; }
        public INavigation Navigation { get; set; }
        public ICommand BtnNavigate { get; set; }
        public ICommand BtnInfo { get; set; }
        public ICommand BtnWeather { get; set; }
        private CavesModel selectionChangedCommandParameter { get; set; }
        private CavesModel _oldCave;

        public CavesViewModel(INavigation navigation)
        {
            Caves = new SightsService().GetListCaves();
            BtnNavigate = new Command(NavigateToSight);
            BtnInfo = new Command(GoToInfoPage);
            BtnWeather = new Command(async () => await ShowWeather());
            Navigation = navigation;
        }
        public void FillCommandGPS(CavesModel cave)
        {
            selectionChangedCommandParameter = cave;

        }
        public void HideOrShowCaves(CavesModel cave)
        {
            if(_oldCave == cave)
            {
                cave.IsVisible = !cave.IsVisible;
                UpdateCave(cave);
            }
            else
            {
                if(_oldCave != null)
                {
                    _oldCave.IsVisible = false;
                    UpdateCave(_oldCave);
                }
                cave.IsVisible = true;
                UpdateCave(cave);
            }
            _oldCave = cave;
        }
        private void UpdateCave(CavesModel cave)
        {
            var index = Caves.IndexOf(cave);
            Caves.Remove(cave);
            Caves.Insert(index, cave);
        }
        public async void NavigateToSight()
        {
            await Map.OpenAsync(selectionChangedCommandParameter.Latitude, selectionChangedCommandParameter.Longtitude, new MapLaunchOptions
            {
                NavigationMode = NavigationMode.Driving,
            });
        }
        public async void GoToInfoPage()
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
            await Navigation.PushAsync(new Weather(selectionChangedCommandParameter.Latitude, selectionChangedCommandParameter.Longtitude));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanges([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
