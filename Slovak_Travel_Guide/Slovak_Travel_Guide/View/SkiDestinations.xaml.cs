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
    public partial class SkiDestinations : ContentPage
    {
        public SkiDestinations()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            BindingContext = new SkiDestinationsViewModel();
        }
    }
}