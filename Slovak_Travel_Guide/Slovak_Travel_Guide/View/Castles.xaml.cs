using Slovak_Travel_Guide.ViewModel;
using System;
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

            BindingContext = new CastlesViewModel();
        }

        async void BtnScrollUpClicked(object sender, EventArgs e)
        {
           // await SVCastles.ScrollToAsync(0, LblCastles.Y, true);
        }
    }
}