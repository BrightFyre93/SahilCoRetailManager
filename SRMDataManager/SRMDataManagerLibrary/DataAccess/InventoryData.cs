using SRMDataManagerLibrary.Internal.DataAccess;
using SRMDataManagerLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace SRMDataManagerLibrary.DataAccess
{
    public class InventoryData
    {
        public List<InventoryModel> GetInventory()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<InventoryModel, dynamic>("dbo.SPInventory_GetAll", new { }, "SRMData").ToList();

            return output;
        }

        public void SaveInventoryRecord(InventoryModel item)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.SaveData("dbo.SPInventory_Insert", item, "SRMData");
        }
    }
}
