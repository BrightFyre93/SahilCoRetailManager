using SRMDesktopUI.Library.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace SRMDesktopUI.Library.API
{
    public interface IApiHelper
    {
        HttpClient ApiClient { get; }

        Task<AuthenticatedUser> AuthenticateAsync(string username, string password);

        void LogOffUser();

        Task GetLoggedInUserInfo(string token);
    }
}