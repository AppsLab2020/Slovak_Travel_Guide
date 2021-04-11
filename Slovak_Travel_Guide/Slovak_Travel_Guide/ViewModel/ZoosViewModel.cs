using Slovak_Travel_Guide.Model;
using Slovak_Travel_Guide.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Slovak_Travel_Guide.ViewModel
{
    class ZoosViewModel : INotifyPropertyChanged
    {
        public List<ZoosModel> Zoos { get; set; }
        public Command<List<double>> BtnNavigate => new Command<List<double>>(NavigateToSight);

        public ZoosViewModel()
        {
            Zoos = new SightsService().GetListZoos();
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
