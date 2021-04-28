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
        public Weather(double latitude, double longitude)
        {
            InitializeComponent();

            BindingContext = new WeatherViewModel(Navigation);

            var vm = BindingContext as WeatherViewModel;

            vm.FillCommandParameterForWeather(latitude, longitude);

        }

    }
}