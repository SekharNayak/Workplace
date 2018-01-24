using System;

namespace Workplace.services.Account
{
    public class AccountService : IAccountService
    {
        public string GetToken(string username, string password)
        {
            //TODO : Implementation
            return "";
        }

        public void SignOut()
        {
            //TODO : Implementation
        }

        public bool ValidateUser(string username, string password)
        {
            //TODO : Implementation
            return true;
        }
    }
}
