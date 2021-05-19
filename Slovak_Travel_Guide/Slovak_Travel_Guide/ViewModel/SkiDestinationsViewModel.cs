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
    class SkiDestinationsViewModel : INotifyPropertyChanged
    {
        INavigation Navigation { get;set; }
        public ObservableCollection<SkiDestinationsModel> SkiDestinations { get; set; }
        public ICommand BtnNavigate { get; set; }
        public ICommand BtnWeather { get; set; }
        public ICommand BtnInfo { get; set; }
        private SkiDestinationsModel selectionChangedCommandParameter { get; set; }
        private SkiDestinationsModel _oldSkiDestination;

        public SkiDestinationsViewModel(INavigation navigation)
        {
            Navigation = navigation;
            SkiDestinations = new SightsService().GetListSkiDestinations();
            BtnNavigate = new Command(NavigateToSight);
            BtnInfo = new Command(GoToWebSite);
            BtnWeather = new Command(async () => await ShowWeather());
        }
        public void FillCommandGPS(SkiDestinationsModel skiDestination)
        {
            selectionChangedCommandParameter = skiDestination;
        }
        public void HideOrShowSkiDestinations(SkiDestinationsModel skiDestination)
        {
            if (_oldSkiDestination == skiDestination)
            {
                skiDestination.IsVisible = !skiDestination.IsVisible;
                UpdateSkiDestination(skiDestination);
            }
            else
            {
                if (_oldSkiDestination != null)
                {
                    _oldSkiDestination.IsVisible = false;
                    UpdateSkiDestination(_oldSkiDestination);
                }
                skiDestination.IsVisible = true;
                UpdateSkiDestination(skiDestination);
            }
            _oldSkiDestination = skiDestination;
        }
        private void UpdateSkiDestination(SkiDestinationsModel skiDestination)
        {
            var index = SkiDestinations.IndexOf(skiDestination);
            SkiDestinations.Remove(skiDestination);
            SkiDestinations.Insert(index, skiDestination);
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
