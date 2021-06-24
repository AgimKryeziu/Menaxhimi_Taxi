using System.Data;
using Taxi.BO;
using Taxi.DAL;

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

        public bool UpdateNderrim(NderrimetBO nderrimetBO)
        {
            return nderrimetDAL.EditNderrim(nderrimetBO);
        }

        public bool DeleteNderrimin(int id)
        {
            return nderrimetDAL.DeleteItem(id);
        }

        public static DataTable SelectNderrimet()
        {
            return NderrimetDAL.SelectNderrimet();
        }
    }
}
