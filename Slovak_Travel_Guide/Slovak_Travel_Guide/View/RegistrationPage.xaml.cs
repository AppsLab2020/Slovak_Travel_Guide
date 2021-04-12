using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Slovak_Travel_Guide.Table;
using Slovak_Travel_Guide.ViewModel;

namespace Slovak_Travel_Guide.Registration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();

            BindingContext = new RegistrationPageViewModel(Navigation);
        }

    }
}