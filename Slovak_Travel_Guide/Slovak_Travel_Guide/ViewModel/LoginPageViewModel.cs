using Slovak_Travel_Guide.Registration;
using Slovak_Travel_Guide.Table;
using SQLite;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Slovak_Travel_Guide.ViewModel
{
    class LoginPageViewModel
    {
        public string TakeName { get; set; }
        public string TakePassword { get; set; }
        public INavigation Navigation { get; set; }
        public ICommand LoginBtnClicked { protected set; get; }
        public ICommand BackToSignUpPageBtn { protected set; get; }

        public LoginPageViewModel()
        {
            this.BackToSignUpPageBtn = new Command(async () => await GoToSignUp());
            this.LoginBtnClicked = new Command(LoginBtn);
        }

        public async Task GoToSignUp()
        {
            await Navigation.PushAsync(new RegistrationPage());
        }

        public async void LoginBtn()
        {
            var UserName = TakeName;
            var UserPassword = TakePassword;
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            var myquery = db.Table<RegUserTable>().Where(u => u.UserName.Equals(UserName) && u.Password.Equals(UserPassword)).FirstOrDefault();

            if (myquery != null)
            {
                App.Current.MainPage = new NavigationPage(new StartMenu());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                   // var result = await this.DisplayAlert("Error", "Failed User Name or Password", "Yes", "Cancel");

                    //if (result)
                        await Navigation.PushAsync(new LoginPage());

                   // else
                    //{
                    //    await Navigation.PushAsync(new LoginPage());
                    //}
                });
            }
        }
    }
}
