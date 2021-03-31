using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Slovak_Travel_Guide.Table;

namespace Slovak_Travel_Guide.Registration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void RegisterButtonClicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<RegUserTable>();

            var item = new RegUserTable()
            {
                UserName = EntryUserName.Text,
                Password = EntryUserPassword.Text,
                Email = EntryUserEmail.Text,
                PhoneNumber = EntryUserPhoneNumber.Text
            };

            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Congratulation", "User Registration Succesfull", "Yes", "Cancel");

                if (result)
                    await Navigation.PushAsync(new LoginPage());
            });
        }
    }
}