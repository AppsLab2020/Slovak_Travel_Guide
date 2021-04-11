using Slovak_Travel_Guide.Registration;
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
            this.Navigation = navigation;
            this.btnTravelClicked = new Command(async () => await GoToSelectPage());
            this.btnSignUp = new Command(async () => await GoToSignUp());
            this.btnLogIn = new Command(async () => await GoToLogIn());
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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanges([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
        
