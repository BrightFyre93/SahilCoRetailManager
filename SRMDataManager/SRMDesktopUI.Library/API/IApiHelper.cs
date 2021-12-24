using SRMDesktopUI.Library.Models;
using System.Threading.Tasks;

namespace SRMDesktopUI.Library.API
{
    public interface IApiHelper
    {
        Task<AuthenticatedUser> AuthenticateAsync(string username, string password);

        Task GetLoggedInUserInfo(string token);
    }
}