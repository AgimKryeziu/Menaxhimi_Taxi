using System.Data;
using Taxi.BO;
using Taxi.DAL;

namespace Taxi.BLL
{
    public class AutomjetiBLL
    {
        AutomjetiDAL automjetiDAL;
        public AutomjetiBLL()
        {
            automjetiDAL = new AutomjetiDAL();
        }
        public DataTable ShowAllCab()
        {
            return automjetiDAL.GetAllCab();
        }

        public AutomjetiBO GetItem(int id)
        {
            return automjetiDAL.GetItemById(id);
        }

        public bool InsertAutomjet(AutomjetiBO automjeti)
        {
            return automjetiDAL.InsertAutomjet(automjeti);
        }

        public bool UpdateAutomjet(AutomjetiBO automjeti)
        {
            return automjetiDAL.EditAutomjet(automjeti);
        }

        public bool DeleteAutomjet(int id)
        {
            return automjetiDAL.DeleteItem(id);
        }

        public static DataTable SelectCab()
        {
            return AutomjetiDAL.SelectCab();
        }
    }
}
