using Slovak_Travel_Guide.Model;
using Slovak_Travel_Guide.ViewModel;
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

            BindingContext = new MountainsViewModel(Navigation);

        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as MountainsViewModel;

            var mountains = e.Item as MountainsModel;

            vm.HideOrShowMountain(mountains);
            vm.FillCommandGPS(mountains);
        }

    }
}