using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Slovak_Travel_Guide.ViewModel
{
    class WebViewViewModel : INotifyPropertyChanged
    {
        public string WebSite { 
            get => webSite; 
            private set
            {
                if (Equals(webSite, value)) return;
                webSite = value;
                OnPropertyChanges();
            }
        }
        private string webSite;
    public WebViewViewModel(string webSite)
        {
            WebSite = webSite;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanges([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }

}
