using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using NewsApp.Services.DependencyServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(NewsApp.Droid.Dependencies.FirebaseAuthentication))]
namespace NewsApp.Droid.Dependencies
{
    public class FirebaseAuthentication : IFirebaseAuthentication
    {
        public string GetCurrentUserName()
        {
            return "No user";
        }

        public bool IsUserSignedIn()
        {
            return true;
        }

        public async Task<bool> UserRegisterUsingEmailAndPassword(string email, string password, string name = null)
        {
            return true;
        }

        public async Task<bool> UserSigninUsingEmailAndPassword(string email, string password)
        {
            return true;
        }
    }
}