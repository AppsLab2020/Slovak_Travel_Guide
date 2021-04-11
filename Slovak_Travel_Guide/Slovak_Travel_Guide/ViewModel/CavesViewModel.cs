using Slovak_Travel_Guide.Model;
using Slovak_Travel_Guide.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Slovak_Travel_Guide.ViewModel
{
    class CavesViewModel : INotifyPropertyChanged
    {
        public List<CavesModel> Caves { get; set; }
        public Command<List<double>> BtnNavigate => new Command<List<double>>(NavigateToSight);

        public CavesViewModel()
        {
            Caves = new SightsService().GetListCaves();
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
