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
    public class NderrimetBLL
    {
        NderrimetDAL nderrimetDAL;

        public NderrimetBLL()
        {
            nderrimetDAL = new NderrimetDAL();
        }

        public DataTable ShowNderrimet()
        {
            return nderrimetDAL.ShowNderrimet();
        }

        public bool InsertNderrim(NderrimetBO nderrimetBO)
        {
            return nderrimetDAL.InsertNderrim(nderrimetBO);
        }

        public NderrimetBO GetItem(int id)
        {
            return nderrimetDAL.GetItemById(id);
        }
    }
}
