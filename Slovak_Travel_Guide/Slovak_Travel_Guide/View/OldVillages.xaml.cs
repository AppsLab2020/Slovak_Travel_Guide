using Slovak_Travel_Guide.Model;
using Slovak_Travel_Guide.ViewModel;
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
    public partial class OldVillages : ContentPage
    {
        public OldVillages()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            BindingContext = new OldVillagesViewModel();
        }
        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as OldVillagesViewModel;

            var oldVillage = e.Item as OldVillagesModel;

            vm.HideOrShowOldVillages(oldVillage);
            vm.FillCommandGPS(oldVillage);
        }
    }
}