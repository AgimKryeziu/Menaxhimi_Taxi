using System.Data;
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

        public static DataTable SelectDestinacionet()
        {
            return DestinacioniDAL.SelectDestinacionet();
        }

        public DataTable DestinacioniReport()
        {
            return destinacionetDAL.DestinacioniReport();
        }
    }
}
