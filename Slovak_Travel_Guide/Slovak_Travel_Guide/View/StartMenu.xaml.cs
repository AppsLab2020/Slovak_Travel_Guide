using Slovak_Travel_Guide.Registration;
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
    public partial class StartMenu : ContentPage
    {
        public StartMenu()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new StartMenuViewModel(Navigation);
        }

        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                var exit = await this.DisplayAlert("Confirm Exit", "Do you really want to exit the application?", "Yes", "No").ConfigureAwait(false);

                if (exit)
                    System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
            });
            return true;
        }

        async void SignInBtnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }
        async void LogInBtnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }



    }
}