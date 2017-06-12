using System;
using System.Threading.Tasks;
using MonkeyFinal.Droid;
using Microsoft.WindowsAzure.MobileServices;
using MonkeyFinal.Service;

[assembly: Xamarin.Forms.Dependency(typeof (AuthenticateDroid))]
namespace MonkeyFinal.Droid
{
    public class AuthenticateDroid : IAuthenticate
    {
        public async Task<MobileServiceUser> Authenticate(MobileServiceClient client, MobileServiceAuthenticationProvider provider)
        {
            try
            {
                return await client.LoginAsync(Xamarin.Forms.Forms.Context, provider);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}