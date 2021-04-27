using Slovak_Travel_Guide.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace Slovak_Travel_Guide.Service
{
    class PreferencesHelper
    {
        public void SaveWeatherInfo(WeatherInfo weatherInfo)
        {
            Preferences.Set(WeatherConstants.TEMPERATURE_PREFERENCES, weatherInfo.Temperature);
            Preferences.Set(WeatherConstants.HUMIDITY_PREFERENCES, weatherInfo.Humidity);
            Preferences.Set(WeatherConstants.PRESSURE_PREFERENCES, weatherInfo.Pressure);
            Preferences.Set(WeatherConstants.IMAGE_URL_PREFERENCES, weatherInfo.ImageUrl);
            Preferences.Set(WeatherConstants.LAST_UPDATE_TIME_PREFERENCES, DateTime.Now);
        }
        public WeatherInfo LoadWeatherInfo()
        {
            int temperature = Preferences.Get(WeatherConstants.TEMPERATURE_PREFERENCES, int.MinValue);
            int humidity = Preferences.Get(WeatherConstants.HUMIDITY_PREFERENCES, int.MinValue);
            int pressure = Preferences.Get(WeatherConstants.PRESSURE_PREFERENCES, int.MinValue);
            string imageCode = Preferences.Get(WeatherConstants.IMAGE_URL_PREFERENCES, null);

            if(temperature == int.MinValue || humidity == int.MinValue || pressure == int.MinValue || imageCode == null)
            {
                return null;
            }
            else
            {
                return new WeatherInfo { Temperature = temperature, Humidity = humidity, Pressure = pressure, ImageUrl = WeatherInfoProvider.CreateImageUrl(imageCode) };
            }
        }
        public DateTime GetLastUpdate()
        {
            return Preferences.Get(WeatherConstants.LAST_UPDATE_TIME_PREFERENCES, DateTime.MinValue);
        }
    }
}
