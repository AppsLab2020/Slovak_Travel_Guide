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

            /*((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.LightGreen;
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.Green;*/

            var navigationPage = Application.Current.MainPage as NavigationPage;
            navigationPage.BarBackgroundColor = Color.LightGreen;
        }

        protected async override void OnAppearing()
        {

            base.OnAppearing();

            var vm = BindingContext as WeatherViewModel;

            await vm.RefreshWeatherData();
        }

    }
}