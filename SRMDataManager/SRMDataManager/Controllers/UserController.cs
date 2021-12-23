using Microsoft.AspNet.Identity;
using SRMDataManagerLibrary.DataAccess;
using SRMDataManagerLibrary.Models;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;

namespace SahilCoRetailManager.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        public List<UserModel> GetById()
        {
            string Id = RequestContext.Principal.Identity.GetUserId();

            UserData data = new UserData();

            return data.GetUserByID(Id);
        }
    }
}
