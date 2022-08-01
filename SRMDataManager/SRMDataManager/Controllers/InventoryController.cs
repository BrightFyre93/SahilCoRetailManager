using Microsoft.AspNet.Identity;
using SRMDataManagerLibrary.DataAccess;
using SRMDataManagerLibrary.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace SahilCoRetailManager.Controllers
{
    [Authorize]
    public class InventoryController : ApiController
    {
        public void Post(InventoryModel item)
        {
            InventoryData data = new InventoryData();

            data.SaveInventoryRecord(item);
        }

        public List<InventoryModel> Get()
        {
            InventoryData data = new InventoryData();
            return data.GetInventory();
        }
    }
}
