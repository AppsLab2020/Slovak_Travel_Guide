using Slovak_Travel_Guide.Registration;
using Slovak_Travel_Guide.Table;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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

        public ICommand RegisterButton
        {
            protected set;
            get;
        }
        public RegistrationPageViewModel()
        {
            RegisterButton = new Command(RegisterNewUser);
        }
        public async void RegisterNewUser()
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
             Device.BeginInvokeOnMainThread(async () =>
            {
                //var result = await this.DisplayAlert("Congratulation", "User Registration Succesfull", "Yes", "Cancel");

                //if (result)
                    await Navigation.PushAsync(new LoginPage());
            });
        }
    }
}
