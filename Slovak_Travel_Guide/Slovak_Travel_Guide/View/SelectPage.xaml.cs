using Slovak_Travel_Guide.Sights;
using Slovak_Travel_Guide.ViewModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Slovak_Travel_Guide
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectPage : ContentPage
    {
        public SelectPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new SelectPageViewModel(Navigation);
        }
    }
}