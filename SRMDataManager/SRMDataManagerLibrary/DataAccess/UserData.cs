using SRMDataManagerLibrary.Internal.DataAccess;
using SRMDataManagerLibrary.Models;
using System.Collections.Generic;

namespace SRMDataManagerLibrary.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserByID(string id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new { Id = id };

            var output = sql.LoadData<UserModel, dynamic>("dbo.[SPUserLookup]", p, "SRMData");

            return output;
        }
    }
}
