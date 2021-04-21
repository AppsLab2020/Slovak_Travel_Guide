using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Slovak_Travel_Guide.ViewModel
{
    class SettingsPageViewModel : INotifyPropertyChanged
    {
        private INavigation Navigation { get; set; }

        public ICommand ChangeThemeToDark { get; set; }

        public SettingsPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            ChangeThemeToDark = new Command(async () => await ChangeDark());
        }

        public async Task ChangeDark()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanges([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
