using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.DAL;
using Taxi.BLL;
using Taxi.BO;

namespace Taxi.BLL
{
    public class ModeletBLL
    {
        ModeletDAL modeletDAL;

        public ModeletBLL()
        {
            modeletDAL = new ModeletDAL();
        }

        public static DataTable SelectModels()
        {
            return ModeletDAL.SelectModels();
        }

        public bool InsertModelt(ModeletBO modeletBO)
        {
            return modeletDAL.InsertModel(modeletBO);
        }

    }
}
