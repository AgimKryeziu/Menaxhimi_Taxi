using System.Data;
using Taxi.BO;
using Taxi.DAL;

namespace Taxi.BLL
{
    public class ShoferiBLL
    {
        ShoferiDAL shoferiDAL;

        public ShoferiBLL()
        {
            shoferiDAL = new ShoferiDAL();
        }

        public DataTable ShowShoferat()
        {
            return shoferiDAL.GetAllShofers();
        }

        public bool CreateShofer(ShoferiBO shoferi)
        {
            return shoferiDAL.InsertShofer(shoferi);
        }

        public ShoferiBO GetItem(int id)
        {
            return shoferiDAL.GetItemById(id);
        }

        public bool UpdateShofer(ShoferiBO shoferi)
        {
            return shoferiDAL.EditShofer(shoferi);
        }

        public bool DeleteShofer(int id)
        {
            return shoferiDAL.DeleteItem(id);
        }

        public static DataTable SelectDrivers()
        {
            return ShoferiDAL.SelectDrivers();
        }

        public DataTable TopShoferi()
        {
            return shoferiDAL.TopShoferi();
        }
        
    }
}
