using System.Threading.Tasks;

namespace Workplace.services.Account
{
    public interface IAccountService
    {
        bool ValidateUser(string username, string password);
        void SignOut();

        string GetToken(string username , string password);
    }
}
