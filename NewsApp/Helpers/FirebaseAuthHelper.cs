using NewsApp.Services.DependencyServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NewsApp.Helpers
{
    public class FirebaseAuthHelper
    {
        private static readonly IFirebaseAuthentication firebaseAuthentication = DependencyService.Get<IFirebaseAuthentication>();
        public static string GetCurrentUserName()
        {
            return firebaseAuthentication.GetCurrentUserName();
        }

        public static bool IsUserSignedIn()
        {
            return firebaseAuthentication.IsUserSignedIn();
        }

        public static Task<bool> UserRegisterUsingEmailAndPassword(string email, string password, string name = null)
        {
            return firebaseAuthentication.UserRegisterUsingEmailAndPassword(email, password, name);
        }

        public static Task<bool> UserSigninUsingEmailAndPassword(string email, string password)
        {
            return firebaseAuthentication.UserSigninUsingEmailAndPassword(email, password);
        }
    }
}
