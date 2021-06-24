using System.Data;
using Taxi.BO;
using Taxi.DAL;

namespace Taxi.BLL
{
    public class RoliBLL
    {
        RoliDAL roliDAL;
        public RoliBLL()
        {
            roliDAL = new RoliDAL();
        }

        public bool CreateRole(RoletBO roletBO)
        {
            return roliDAL.InsertRole(roletBO);
        }

        public static DataTable SelectRoles()
        {
            return RoliDAL.SelectRoles();
        }
    }
}
