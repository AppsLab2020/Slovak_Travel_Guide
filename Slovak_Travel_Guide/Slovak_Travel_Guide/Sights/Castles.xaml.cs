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
    public partial class Castles : ContentPage
    {
        public Castles()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        async void BtnScrollUpClicked(object sender, EventArgs e)
        {
           // await SVCastles.ScrollToAsync(0, LblCastles.Y, true);
        }
    }
}