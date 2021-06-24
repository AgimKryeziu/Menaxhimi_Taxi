using System;
using System.Data;
using System.Data.SqlClient;
using Taxi.BO;

namespace Taxi.DAL
{
    public class ModeletDAL
    {
        public static DataTable SelectModels()
        {
            try
            {
                using (DatabaseConn.conn = new SqlConnection(DatabaseConn.conString))
                {
                    DatabaseConn.da = new SqlDataAdapter("usp_SelectModels", DatabaseConn.conn);
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

        public bool InsertModelet(ModeletBO modeletBO)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConn.conString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_InsertModel", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Emri", modeletBO.Emri);
                    cmd.Parameters.AddWithValue("@Pershkrimi", modeletBO.Pershkrimi);
                    cmd.Parameters.AddWithValue("@InsertedBy", modeletBO.InsertBy);
                    cmd.Parameters.AddWithValue("@InsertDate", modeletBO.InsertDate);

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
