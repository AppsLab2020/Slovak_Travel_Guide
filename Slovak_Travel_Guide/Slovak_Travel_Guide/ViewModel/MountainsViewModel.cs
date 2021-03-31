﻿using Slovak_Travel_Guide.Service;
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
        public List<Mountains> Mountains { get; set; }
        public ICommand BtnNavigate
        {
            protected set;
            get;
        }

        public MountainsViewModel()
        {
            Mountains = new SightsService().GetListMountains();
            this.BtnNavigate = new Command(async () => await NavigateToSight());
        }
        public async Task NavigateToSight()
        {
            double latitude = 48.142248;
            double longitude = 17.0996481;

            await Map.OpenAsync(latitude, longitude, new MapLaunchOptions
            {
                Name = "Bratislavsky Hrad",
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