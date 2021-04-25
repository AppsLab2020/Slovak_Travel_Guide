﻿using Slovak_Travel_Guide.Model;
using Slovak_Travel_Guide.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<MountainsModel> Mountains { get; set; }
        public ICommand BtnNavigate { get; set; }
        public ICommand SelectionChangedCommand { get; set; }
        public ICommand BtnInfo { get; set; }
        private MountainsModel selectionChangedCommandParameter { get; set; }
        private MountainsModel _oldMountains;
        public MountainsViewModel()
        {
            Mountains = new SightsService().GetListMountains();
            BtnNavigate = new Command(NavigateToSight);
            BtnInfo = new Command(GoToWebSite);
        }

        public void FillCommandGPS(MountainsModel mountain)
        {
            selectionChangedCommandParameter = mountain;
        }

        public void HideOrShowMountain(MountainsModel mountain)
        {
            if (_oldMountains == mountain)
            {
                mountain.IsVisible = !mountain.IsVisible;
                UpdateMountain(mountain);
            }
            else
            {
                if (_oldMountains != null)
                {
                    _oldMountains.IsVisible = false;
                    UpdateMountain(_oldMountains);
                }
                mountain.IsVisible = true;
                UpdateMountain(mountain);
            }
            _oldMountains = mountain;
        }
        private void UpdateMountain(MountainsModel mountain)
        {
            var index = Mountains.IndexOf(mountain);
            Mountains.Remove(mountain);
            Mountains.Insert(index, mountain);
        }

        public async void NavigateToSight()
        {
            await Map.OpenAsync(selectionChangedCommandParameter.Latitude, selectionChangedCommandParameter.Longtitude, new MapLaunchOptions
            {
                NavigationMode = NavigationMode.Driving,
            });
        }
        public async void GoToWebSite()
        {
            Device.OpenUri(new Uri(selectionChangedCommandParameter.WebSite));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanges([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
