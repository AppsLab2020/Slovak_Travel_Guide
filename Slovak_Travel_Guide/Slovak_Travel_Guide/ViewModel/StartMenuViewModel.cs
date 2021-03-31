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
        }
        public ICommand btnTravelClicked
        {
            protected set;
            get;
        }

        public async Task GoToSelectPage()
        {
            await Navigation.PushAsync(new SelectPage());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanges([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
        
