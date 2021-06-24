using System.Data;
using Taxi.BO;
using Taxi.DAL;

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

        public bool InsertModelet(ModeletBO modeletBO)
        {
            return modeletDAL.InsertModelet(modeletBO);
        }

    }
}
