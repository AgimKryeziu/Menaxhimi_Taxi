using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.DAL
{
    class RoliDAL
    {
        public static int GetRoleId(string username, string password)
        {
            try
            {
                using (DatabaseConn.conn = new SqlConnection(DatabaseConn.conString))
                {
                    DatabaseConn.conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_LoginRole", DatabaseConn.conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int rezultati = (int)cmd.ExecuteScalar();
                    return rezultati;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                DatabaseConn.conn.Close();
            }
        }
    }
}
