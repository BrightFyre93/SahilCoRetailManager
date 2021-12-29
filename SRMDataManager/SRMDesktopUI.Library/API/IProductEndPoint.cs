using SRMDesktopUI.Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SRMDesktopUI.Library.API
{
    public interface IProductEndPoint
    {
        Task<List<ProductModel>> GetAll();
    }
}