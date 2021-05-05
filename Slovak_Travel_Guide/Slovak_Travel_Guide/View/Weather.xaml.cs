using Slovak_Travel_Guide.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Slovak_Travel_Guide.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Weather : ContentPage
    {
        public Weather(double latitude, double longitude, string name)
        {
            InitializeComponent();

            BindingContext = new WeatherViewModel(latitude, longitude, name);

        }

        protected async override void OnAppearing()
        {

            base.OnAppearing();

            var vm = BindingContext as WeatherViewModel;

            await vm.RefreshWeatherData();
        }

    }
}