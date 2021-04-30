using Slovak_Travel_Guide.Model;
using Slovak_Travel_Guide.Service;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Slovak_Travel_Guide.ViewModel
{
    class WeatherViewModel : INotifyPropertyChanged
    {
        const int savedDataExpirationHours = 3;
        WeatherInfoProvider weatherInfoProvider;
        PreferencesHelper preferencesHelper;
        private double Latitude { get; set; }
        private double Longitude { get; set; }
        public INavigation Navigation { get;set; }
        public ICommand PreviousPage { get; set; }
        public string LastUpdate { get; set; }
        public string Temperature { get; set; }
        public string Pressure { get; set; }
        public string Humidity { get; set; }
        public string WeatherUrl { get; set; }


        public WeatherViewModel(INavigation navigation)
        {
            Navigation = navigation;
            weatherInfoProvider = new WeatherInfoProvider();
            preferencesHelper = new PreferencesHelper();
            PreviousPage = new Command(async () => await NavigateToBack());

        }
        public async Task NavigateToBack()
        {
            Navigation.PushAsync(new SelectPage());
        }
        public void FillCommandParameterForWeather(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        
        public async Task RefreshWeatherData()
        {
            await UpdateWeatherData(Latitude, Longitude);
        }
        private async Task UpdateWeatherData(double latitude, double longitude)
        {
            ResetUI();

            WeatherInfo weatherInfo = null;

            if(Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                weatherInfo = await weatherInfoProvider.GetLocation(latitude, longitude);
                if(weatherInfo != null)
                {
                    preferencesHelper.SaveWeatherInfo(weatherInfo);
                    UpdateUIWithNewInfo(weatherInfo);
                }
            }
            else
            {
                if (SavedDataIsCurrent())
                    weatherInfo = preferencesHelper.LoadWeatherInfo();
                if (weatherInfo != null)
                    UpdateUIWithNewInfo(weatherInfo);
            }
        }
        private void UpdateUIWithNewInfo(WeatherInfo weatherInfo)
        {
            Temperature = weatherInfo.Temperature.ToString() + "°";
            Pressure = weatherInfo.Pressure.ToString() + " hPa";
            Humidity = weatherInfo.Humidity.ToString() + " %";
            LastUpdate = $"Last update: {preferencesHelper.GetLastUpdate().ToString("HH:mm")}";
            WeatherUrl = weatherInfo.ImageUrl;
        }
        private bool SavedDataIsCurrent()
        {
            return DateTime.Now - preferencesHelper.GetLastUpdate() < TimeSpan.FromHours(savedDataExpirationHours);
        }
        private void ResetUI()
        {
            Temperature = "-°";
            Pressure = "- hPa";
            Humidity = "- %";
            LastUpdate = "Last update: -";
            WeatherUrl = null;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanges([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
