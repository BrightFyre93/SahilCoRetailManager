using SRMDataManagerLibrary.Internal.DataAccess;
using SRMDataManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
