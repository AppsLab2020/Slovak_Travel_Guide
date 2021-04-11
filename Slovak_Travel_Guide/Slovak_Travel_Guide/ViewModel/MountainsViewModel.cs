using Slovak_Travel_Guide.Model;
using Slovak_Travel_Guide.Service;
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
    class MountainsViewModel : INotifyPropertyChanged
    {
        public List<MountainsModel> Mountains { get; set; }
        public Command<List<double>> BtnNavigate => new Command<List<double>>(NavigateToSight);

        public MountainsViewModel()
        {
            Mountains = new SightsService().GetListMountains();
            Console.WriteLine();
        }

        public async void NavigateToSight(List<double> LatitudeAndLongtitude)
        {
            await Map.OpenAsync(LatitudeAndLongtitude[0], LatitudeAndLongtitude[1], new MapLaunchOptions
            {
                NavigationMode = NavigationMode.Driving,
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanges([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
