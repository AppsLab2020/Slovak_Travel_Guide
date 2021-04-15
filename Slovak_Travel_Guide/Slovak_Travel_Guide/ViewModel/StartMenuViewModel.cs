using Slovak_Travel_Guide.Registration;
using Slovak_Travel_Guide.View;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Slovak_Travel_Guide.ViewModel
{
    class StartMenuViewModel : INotifyPropertyChanged
    {
        public INavigation Navigation { get; set; }

        public StartMenuViewModel(INavigation navigation)
        {
            Navigation = navigation;
            btnTravelClicked = new Command(async () => await GoToSelectPage());
            btnSignUp = new Command(async () => await GoToSignUp());
            btnLogIn = new Command(async () => await GoToLogIn());
            btnSettings = new Command(async () => await GoToSettingsPage());
        }
        public ICommand btnTravelClicked
        {
            protected set;
            get;
        }
        public ICommand btnSignUp
        {
            protected set;
            get;
        }
        public ICommand btnLogIn
        {
            protected set;
            get;
        }

        public ICommand btnSettings
        {
            protected set;
            get;
        }

        public async Task GoToSelectPage()
        {
            await Navigation.PushAsync(new SelectPage());
        }
        public async Task GoToSignUp()
        {
            await Navigation.PushAsync(new RegistrationPage());
        }
        public async Task GoToLogIn()
        {
            await Navigation.PushAsync(new LoginPage());
        }

        public async Task GoToSettingsPage()
        {
            await Navigation.PushAsync(new SettingsPage());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanges([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
        
