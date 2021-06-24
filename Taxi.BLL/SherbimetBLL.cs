using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.BO;
using Taxi.DAL;

namespace Taxi.BLL
{
    public class SherbimetBLL
    {
        SherbimetDAL sherbimetDAL;

        public SherbimetBLL()
        {
            sherbimetDAL = new SherbimetDAL();
        }

        public DataTable ShowServices()
        {
            return sherbimetDAL.GetAllServices();
        }

        public SherbimetBO GetItem(int id)
        {
            return sherbimetDAL.GetItemById(id);
        }

        public bool CreateService(SherbimetBO sherbimetBO)
        {
            return sherbimetDAL.InsertService(sherbimetBO);
        }

        public bool UpdateService(SherbimetBO sherbimetBO)
        {
            return sherbimetDAL.EditService(sherbimetBO);
        }

        
    }
}
