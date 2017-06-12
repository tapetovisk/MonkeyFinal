using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;

namespace MonkeyFinal.Service
{
    public interface IAuthenticate
    {
        Task<MobileServiceUser> Authenticate(MobileServiceClient client, MobileServiceAuthenticationProvider provider);
    }
}
