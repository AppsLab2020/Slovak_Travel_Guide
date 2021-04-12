using Slovak_Travel_Guide.Registration;
using Slovak_Travel_Guide.Table;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Slovak_Travel_Guide.ViewModel
{
    class RegistrationPageViewModel
    {
        public string TakeUserName { get; set; } 
        public string TakeUserPassword { get; set; }
        public string TakeEmail { get; set; }
        public string TakePhoneNumber { get; set; }
        public INavigation Navigation { get; set; }

        public string UrlSignUp { get; set; }
        public string UsersIcon { get; set; }

        public ICommand RegisterButton
        {
            protected set;
            get;
        }
        public RegistrationPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            RegisterButton = new Command(async () => await RegisterNewUser());
            UrlSignUp = "https://borlabs.io/wp-content/uploads/2019/09/blog-wp-login.png";
            UsersIcon = "https://www.pikpng.com/pngl/m/16-168124_png-file-svg-font-awesome-users-icon-clipart.png";
        }
        public async Task RegisterNewUser()
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<RegUserTable>();

           var userName = TakeUserName;
           var userPassword = TakeUserPassword;
           var userEmail = TakeEmail;
           var userPhoneNumber = TakePhoneNumber;
            var item = new RegUserTable()
            {
                UserName = userName,
                Password = userPassword,
                Email = userEmail,
                PhoneNumber = userPhoneNumber,
            };
            db.Insert(item);
            db.Close();
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await App.Current.MainPage.DisplayAlert("Congratulation", "User Registration Succesfull", "Yes", "Cancel");

                if (result)
                    await Navigation.PushAsync(new LoginPage());
            });
        }
    }
}
