using Microsoft.AspNet.Identity;
using SRMDataManagerLibrary.DataAccess;
using SRMDataManagerLibrary.Models;
using System.Web.Http;

namespace SahilCoRetailManager.Controllers
{
    [Authorize]
    public class SaleController : ApiController
    {
        public void Post(SaleModel sale)
        {
            SaleData data = new SaleData();

            string userId = RequestContext.Principal.Identity.GetUserId();

            data.SaveSale(sale, userId);
        }
    }
}
