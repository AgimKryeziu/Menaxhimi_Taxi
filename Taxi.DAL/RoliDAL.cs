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
    public class RoliDAL
    {
        public bool InsertRole (RoletBO roletBO)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConn.conString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_InsertRole", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Pershkrimi", roletBO.Pershkrimi);
                    cmd.Parameters.AddWithValue("@InsertBy", roletBO.InsertBy);
                    cmd.Parameters.AddWithValue("@InsertDate", roletBO.InsertDate);

                    cmd.ExecuteNonQuery();
                }
                return true;
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
