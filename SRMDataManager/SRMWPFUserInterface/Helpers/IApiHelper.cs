using SRMDesktopUI.Models;
using System.Threading.Tasks;

namespace SRMDesktopUI.Helpers
{
    public interface IApiHelper
    {
        Task<AuthenticatedUser> AuthenticateAsync(string username, string password);
    }
}