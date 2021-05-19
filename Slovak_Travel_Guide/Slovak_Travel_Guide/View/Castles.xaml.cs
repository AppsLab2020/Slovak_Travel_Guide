using Slovak_Travel_Guide.Model;
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

            BindingContext = new CastlesViewModel(Navigation);
        }
        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as CastlesViewModel;

            var cave = e.Item as CastlesModel;

            vm.HideOrShowCastles(cave);
            vm.FillCommandGPS(cave);
        }
    }
}