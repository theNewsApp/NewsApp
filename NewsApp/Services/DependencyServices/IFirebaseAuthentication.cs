using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Services.DependencyServices
{
    public interface IFirebaseAuthentication
    {
        Task<bool> UserSigninUsingEmailAndPassword(string email, string password);
        Task<bool> UserRegisterUsingEmailAndPassword( string email, string password, string name = null);
        bool IsUserSignedIn();
        string GetCurrentUserName();
    }
}
