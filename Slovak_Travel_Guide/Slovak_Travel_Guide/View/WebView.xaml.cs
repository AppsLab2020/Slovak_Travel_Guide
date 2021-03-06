﻿using Slovak_Travel_Guide.ViewModel;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Slovak_Travel_Guide.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebView : INotifyPropertyChanged
    {
        public WebView(string WebSite)
        {
            InitializeComponent();

            BindingContext = new WebViewViewModel(WebSite);

            var navigationPage = Application.Current.MainPage as NavigationPage;
            navigationPage.BarBackgroundColor = Color.Green;
        }

        private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
        {

        }
    }
}