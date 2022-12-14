using SRMDataManagerLibrary.Internal.DataAccess;
using SRMDataManagerLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace SRMDataManagerLibrary.DataAccess
{
    public class ProductData
    {
        public List<ProductModel> GetProducts()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<ProductModel, dynamic>("dbo.[SPProduct_GetAll]", new { }, "SRMData");

            return output;
        }

        public ProductModel GetProductById(int ProductId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<ProductModel, dynamic>("dbo.[SPProduct_GetById]", new { Id = ProductId }, "SRMData").FirstOrDefault();

            return output;
        }
    }
}
