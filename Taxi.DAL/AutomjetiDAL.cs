using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.BO;

namespace Taxi.DAL
{
    public class AutomjetiDAL
    {
        public DataTable GetAllCab()
        {
            try
            {
                using (DatabaseConn.conn = new SqlConnection(DatabaseConn.conString))
                {
                    DatabaseConn.da = new SqlDataAdapter("usp_ShowAutomjetet", DatabaseConn.conn);
                    DataTable dTable = new DataTable();
                    DatabaseConn.da.Fill(dTable);

                    return dTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public bool InsertAutomjet(AutomjetiBO automjeti)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConn.conString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_InsertAutomjetin", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@@Targa", automjeti.Targa);
                    cmd.Parameters.AddWithValue("@ModeliId", automjeti.Modelet);
                    cmd.Parameters.AddWithValue("@VitiIProdhimit", automjeti.VitiIProdhimit);
                    cmd.Parameters.AddWithValue("@Kilometrat", automjeti.Km);
                    cmd.Parameters.AddWithValue("@Aktiv", automjeti.Aktiv);
                    cmd.Parameters.AddWithValue("@InsertBy", automjeti.InsertBy);
                    cmd.Parameters.AddWithValue("@InsertDate", automjeti.InsertDate);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
