
using Slovak_Travel_Guide.ViewModel;
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

            BindingContext = new CavesViewModel();
        }
    }
}