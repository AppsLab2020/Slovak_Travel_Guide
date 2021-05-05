using Slovak_Travel_Guide.Model;
using Slovak_Travel_Guide.Service;
using System;
using System.Collections.Generic;
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
        public string LastUpdateLabel 
        { 
            get => lastUpadteLabel; 
            private set
            {
                if (Equals(lastUpadteLabel, value)) return;
                lastUpadteLabel = value;
                OnPropertyChanges();
            }
        }
        private string lastUpadteLabel;
        public string TemperatureLabel
        {
            get => temperatureLabel;
            private set
            {
                if (Equals(temperatureLabel, value)) return;
                temperatureLabel = value;
                OnPropertyChanges();
            }
        }
        public string temperatureLabel;
        public string PressureLabel
        {
            get => pressureLabel;
            private set
            {
                if (Equals(pressureLabel, value)) return;
                pressureLabel = value;
                OnPropertyChanges();
            }
        }
        public string pressureLabel;
        public string HumidityLabel
        {
            get => huminidityLabel;
            private set
            {
                if (Equals(huminidityLabel, value)) return;
                huminidityLabel = value;
                OnPropertyChanges();
            }
        }
        public string huminidityLabel;
        public string WeatherUrlLabel
        {
            get => weatherUrlLabel;
            private set
            {
                if (Equals(weatherUrlLabel, value)) return;
                weatherUrlLabel = value;
                OnPropertyChanges();
            }
        }
        public string weatherUrlLabel;
        public ICommand Reset { get; }
        public WeatherViewModel(double latitude, double longitude)
        {
            weatherInfoProvider = new WeatherInfoProvider();
            preferencesHelper = new PreferencesHelper();
            Reset = new Command(async () => await RefreshWeatherData());
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
            TemperatureLabel = weatherInfo.Temperature.ToString() + "°";
            PressureLabel = weatherInfo.Pressure.ToString() + " hPa";
            HumidityLabel = weatherInfo.Humidity.ToString() + " %";
            LastUpdateLabel = $"{preferencesHelper.GetLastUpdate().ToString("HH:mm")}";
            WeatherUrlLabel = weatherInfo.ImageUrl;

        }
        private bool SavedDataIsCurrent()
        {
            return DateTime.Now - preferencesHelper.GetLastUpdate() < TimeSpan.FromHours(savedDataExpirationHours);
        }
        private void ResetUI()
        {
            TemperatureLabel = "-°";
            PressureLabel = "- hPa";
            HumidityLabel = "- %";
            LastUpdateLabel = "-";
            WeatherUrlLabel = null;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanges([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
