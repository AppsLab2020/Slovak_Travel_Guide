using Slovak_Travel_Guide.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Slovak_Travel_Guide.Sights
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Castles : ContentPage
    {
        public Castles()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        async void BtnScrollUpClicked(object sender, EventArgs e)
        {
           // await SVCastles.ScrollToAsync(0, LblCastles.Y, true);
        }

        private async void NavigateGpsBratislavskyHrad(object sender, EventArgs e)
        {
            double latitude = 48.142248;
            double longitude = 17.0996481;

            await Map.OpenAsync(latitude, longitude, new MapLaunchOptions
            {
                Name = "Bratislavsky Hrad",
                NavigationMode = NavigationMode.Driving,
            });
        }

        private async void NavigateGpsOravskyHrad(object sender, EventArgs e)
        {
            double latitude = 49.2620572;
            double longitude = 19.358658;

            await Map.OpenAsync(latitude, longitude, new MapLaunchOptions
            {
                Name = "Oravsky Hrad",
                NavigationMode = NavigationMode.Driving,
            });
        }
    }
}