
using Slovak_Travel_Guide.Model;
using Slovak_Travel_Guide.ViewModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Slovak_Travel_Guide.Sights
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Caves : ContentPage
    {
        public Caves()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            BindingContext = new CavesViewModel(Navigation);
        }
       private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
       {
            var vm = BindingContext as CavesViewModel;

            var cave = e.Item as CavesModel;

            vm.HideOrShowCaves(cave);
            vm.FillCommandGPS(cave);

       }
       
    }
}