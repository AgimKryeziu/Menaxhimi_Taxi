using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.BO;
using Taxi.DAL;


namespace Taxi.BLL
{
    public class DestinacionetBLL
    {
        DestinacioniDAL destinacionetDAL;

        public DestinacionetBLL()
        {
            destinacionetDAL = new DestinacioniDAL();
        }

        public bool CreateDestinacion(DestinacioniBO destinacioniBO)
        {
            return destinacionetDAL.InsertDestinacion(destinacioniBO);
        }
    }
}
