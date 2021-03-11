using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Slovak_Travel_Guide
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mountains : ContentPage
    {
        public Mountains()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

        }

        private async void BtnNavigateClicked(object sender, EventArgs e)
        {
            double latitude = 49.23403;
            double longitude = 19.0974212;

            await Map.OpenAsync(latitude, longitude, new MapLaunchOptions
            {
                Name = "Rozsutec",
                NavigationMode = NavigationMode.None,
            }) ;
        }
    }
}