using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShopApp.UIForms.ViewModels
{
    public class LoginViewModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public LoginViewModel()
        {
            this.Email = "richard.mazo.15.11@gmail.com";
            this.Password = "123456";
        }

        public ICommand LoginCommand => new RelayCommand(Login);

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must enter a Email", "Accept");
                return;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must enter a password", "Accept");
                return;
            }
            if (!this.Email.Equals("richard.mazo.15.11@gmail.com") || !this.Password.Equals("123456"))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "User or password wrong.", "Accept");
                return;
            }
            await Application.Current.MainPage.DisplayAlert("Ok", "Fuck Yeah!!!", "Accept");
        }
    }
}
