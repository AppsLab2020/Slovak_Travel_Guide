using Slovak_Travel_Guide.Sights;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Slovak_Travel_Guide.ViewModel
{
    class SelectPageViewModel : INotifyPropertyChanged
    {
        public INavigation Navigation { get; set; }
        public ICommand CastlesBtnClicked
        { 
            protected set;
            get;
        }
        public ICommand CavesBtnClicked
        {
            protected set;
            get;
        }
        public ICommand ZoosBtnClicked
        {
            protected set;
            get;
        }
        public ICommand OldVillagesBtnClicked
        {
            protected set;
            get;
        }
        public ICommand SkiDestinationsBtnClicked
        {
            protected set;
            get;
        }
        public ICommand MountainsBtnClicked
        {
            protected set;
            get;
        }

        public SelectPageViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            this.CastlesBtnClicked = new Command(async () => await GoToCastles());
            this.CavesBtnClicked = new Command(async () => await GoToCaves());
            this.ZoosBtnClicked = new Command(async () => await GoToZoos());
            this.OldVillagesBtnClicked = new Command(async() => await GoToOldVillages());
            this.SkiDestinationsBtnClicked = new Command(async () => await GoToSkiDestinations());
            this.MountainsBtnClicked = new Command(async () => await GoToMountains());
        }
        public async Task GoToCastles()
        {
            await Navigation.PushAsync(new Castles());
        }
        public async Task GoToCaves()
        {
            await Navigation.PushAsync(new Caves());
        }
        public async Task GoToZoos()
        {
            await Navigation.PushAsync(new Zoos());
        }
        public async Task GoToOldVillages()
        {
            await Navigation.PushAsync(new OldVillages());
        }
        public async Task GoToSkiDestinations()
        {
            await Navigation.PushAsync(new SkiDestinations());
        }
        public async Task GoToMountains()
        {
            await Navigation.PushAsync(new Mountains());
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanges([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
