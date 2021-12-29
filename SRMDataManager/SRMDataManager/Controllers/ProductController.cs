using SRMDataManagerLibrary.DataAccess;
using SRMDataManagerLibrary.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace SahilCoRetailManager.Controllers
{
    [Authorize]
    public class ProductController : ApiController
    {
        // GET api/values
        public List<ProductModel> Get()
        {
            ProductData data = new ProductData();

            return data.GetProducts();
        }

    }
}
