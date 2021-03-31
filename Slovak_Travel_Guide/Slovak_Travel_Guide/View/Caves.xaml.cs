using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}