using Slovak_Travel_Guide.Model;
using Slovak_Travel_Guide.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Slovak_Travel_Guide.ViewModel
{
    class SkiDestinationsViewModel : INotifyPropertyChanged
    {
        public List<SkiDestinationsModel> SkiDestinations { get; set; }
        public Command<List<double>> BtnNavigate => new Command<List<double>>(NavigateToSight);

        public SkiDestinationsViewModel()
        {
            SkiDestinations = new SightsService().GetListSkiDestinations();
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
