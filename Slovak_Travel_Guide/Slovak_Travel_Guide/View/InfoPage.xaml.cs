using Slovak_Travel_Guide.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Slovak_Travel_Guide.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPage : ContentPage
    {
        public InfoPage(string webSite, string aboutSight, string name, string url1, string url2, string url3, string url4)
        {
            InitializeComponent();

            BindingContext = new InfoPageViewModel(Navigation, webSite, aboutSight, name, url1, url2, url3, url4);
        }
    }
}