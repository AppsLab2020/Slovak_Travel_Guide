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

            BindingContext = new MountainsViewModel();

        }

    }
}