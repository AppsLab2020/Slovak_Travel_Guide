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
        public string UrlSignUp { get; set; }
        public string UsersIcon { get; set; }

        public LoginPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            this.BackToSignUpPageBtn = new Command(async () => await GoToSignUp());
            this.LoginBtnClicked = new Command(async () => await LoginBtn());
            UrlSignUp = "https://borlabs.io/wp-content/uploads/2019/09/blog-wp-login.png";
            UsersIcon = "https://www.pikpng.com/pngl/m/16-168124_png-file-svg-font-awesome-users-icon-clipart.png";
        }

        public async Task GoToSignUp()
        {
            await Navigation.PushAsync(new RegistrationPage());
        }

        public async Task LoginBtn()
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
                   var result = await App.Current.MainPage.DisplayAlert("Error", "Failed User Name or Password", "Yes", "Cancel");

                    if (result)
                    { 
                        await Navigation.PushAsync(new StartMenu());
                    }
                    else
                    {
                        await Navigation.PushAsync(new LoginPage());
                    }
                });
            }
        }
    }
}
