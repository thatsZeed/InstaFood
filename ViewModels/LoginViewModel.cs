using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using InstaFood.Models;

namespace InstaFood.ViewModels
{
    public partial class LoginViewModel
    {
        public string _username = "test";
        public string _password = "test";
        public string _email;
        public DateTime _birthday;

        public string Username { get => _username; set => _username = value; }

        public string Password { get => _password; set => _password = value; }

        public string Email { get => _email; set => _email = value; }

        public DateTime Birthday { get => _birthday; set => _birthday = value; }

        private INavigation Navigation { get; set; }

        public ICommand LoginCommand { get; set; }

        public ICommand ResetPasswordCommand { get; set; }

        public ICommand RegisterCommand { get; set; }

        public LoginViewModel(INavigation _navigation)
        {
            LoginCommand = new Command(OnLoginCommand);
            RegisterCommand = new Command(OnRegisterCommand);
            ResetPasswordCommand = new Command(OnResetPasswordCommand);

            Navigation = _navigation;
        }

        public async void OnLoginCommand()
        {
            var logindata = await App.Database.GetLoginData(Username, Password);
            if (logindata != null)
            {
                await Navigation.PushModalAsync(new MainPage());
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Fehler", "Username ungültig!", "OK");
            }

        }

        private async void OnRegisterCommand()
        {
            User user = new User();
            user.Username = _username;
            user.Password = _password;
            user.Email = _email;
            user.Birthday = _birthday;
            await App.Database.SaveLoginData(user);
#pragma warning disable CA1416 // Plattformkompatibilität überprüfen
            await App.Current.MainPage.DisplayAlert("Registrierung erfolgreich", "Sie haben sich erfolgreich registiert. Schauen Sie in Ihr E-Mail Postfach, um sich zu verifizieren.", "OK");
#pragma warning restore CA1416 // Plattformkompatibilität überprüfen
        }

        public async void OnResetPasswordCommand()
        {

        }
    }
}
