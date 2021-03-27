using Slovak_Travel_Guide.Registration;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Slovak_Travel_Guide
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StartMenu()); /*{ BarBackgroundColor = Color.FromHex("#D7812A"), BarTextColor = Color.White, };*/

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
