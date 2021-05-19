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
    class OldVillagesViewModel : INotifyPropertyChanged
    {
        INavigation Navigation { get; set; }
        public ObservableCollection<OldVillagesModel> OldVillages { get; set; }
        public ICommand BtnNavigate { get; set; }
        public ICommand BtnWeather { get; set; }
        public ICommand BtnInfo { get; set; }
        private OldVillagesModel selectionChangedCommandParameter { get; set; }
        private OldVillagesModel _oldOldVillage;

        public OldVillagesViewModel(INavigation navigation)
        {
            Navigation = navigation;
            OldVillages = new SightsService().GetListOldVillages();
            BtnNavigate = new Command(NavigateToSight);
            BtnInfo = new Command(GoToWebSite);
            BtnWeather = new Command(async () => await ShowWeather());
        }
        public void FillCommandGPS(OldVillagesModel oldVillage)
        {
            selectionChangedCommandParameter = oldVillage;
        }
        public void HideOrShowOldVillages(OldVillagesModel oldVillage)
        {
            if (_oldOldVillage == oldVillage)
            {
                oldVillage.IsVisible = !oldVillage.IsVisible;
                UpdateOldVillage(oldVillage);
            }
            else
            {
                if (_oldOldVillage != null)
                {
                    _oldOldVillage.IsVisible = false;
                    UpdateOldVillage(_oldOldVillage);
                }
                oldVillage.IsVisible = true;
                UpdateOldVillage(oldVillage);
            }
            _oldOldVillage = oldVillage;
        }
        private void UpdateOldVillage(OldVillagesModel oldVillage)
        {
            var index = OldVillages.IndexOf(oldVillage);
            OldVillages.Remove(oldVillage);
            OldVillages.Insert(index, oldVillage);
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
