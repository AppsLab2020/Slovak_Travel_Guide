using Slovak_Travel_Guide.Sights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Slovak_Travel_Guide
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectPage : ContentPage
    {
        public SelectPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        async void CastlesBtnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Castles());
        }

        async void CavesBtnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Caves());
        }

        async void ZoosBtnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Zoos());
        }
        async void OldVillagesBtnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OldVillages());
        }
        async void SkiDestinationsBtnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SkiDestinations());
        }
        async void MountainsBtnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Mountains());
        }
    }
}