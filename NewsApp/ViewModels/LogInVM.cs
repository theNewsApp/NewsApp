using NewsApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace NewsApp.ViewModels
{
    public class LogInVM:BaseVM
    {
        private string _email;

        public string Email
        {
            get { return _email; }
            set 
            { 
                _email = value;
                OnPropertyChange("Email");
                OnPropertyChange("CanLogin");
            }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set 
            { 
                _password = value;
                OnPropertyChange("Password");
                OnPropertyChange("CanLogin");
            }
        }

        public ICommand LoginCommand { get; set; }
        public LogInVM()
        {
            LoginCommand = new Command(LoginCommandImpl, LoginCanExecute);
        }
        public bool CanLogin
        {
            get
            {
                return !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password);
            }
        }
        private bool LoginCanExecute(object arg)
        {
            return CanLogin;
        }

        private async void LoginCommandImpl(object obj)
        {
            var result = await FirebaseAuthHelper.UserSigninUsingEmailAndPassword(Email,Password);
            if (result)
                await App.Current.MainPage.DisplayAlert("Success", "Login was successful", "Ok");
            else
                await App.Current.MainPage.DisplayAlert("Failure", "Failed to login. Try with correct credentials.", "Ok");
        }
    }
}
