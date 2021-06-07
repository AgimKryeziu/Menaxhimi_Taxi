using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.BO;
using Taxi.DAL;

namespace Taxi.BLL
{
    class RoliBLL
    {
        RoliDAL roliDAL;

        public bool CreateShofer(RoletBO roletBO)
        {
            return roliDAL.InsertRole(roletBO);
        }
    }
}
