using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.DAL;
using Taxi.BO;
using System.Data;

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
    }
}
