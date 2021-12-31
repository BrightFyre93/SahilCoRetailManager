using SRMDesktopUI.Library.Models;
using System.Threading.Tasks;

namespace SRMDesktopUI.Library.API
{
    public interface ISaleEndPoint
    {
        Task PostSale(SaleModel sale);
    }
}