using System;
using System.Data;
using System.Data.SqlClient;
using Taxi.BO;

namespace Taxi.DAL
{
    public class DestinacioniDAL
    {
        public bool InsertDestinacion(DestinacioniBO destinacionet)
        {
            AdresaBO adresaBO = new AdresaBO();
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConn.conString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_InsertDestinacion", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Shteti", destinacionet.Adresa.Shteti);
                    cmd.Parameters.AddWithValue("@Qyteti", destinacionet.Adresa.Qyteti);
                    cmd.Parameters.AddWithValue("@Lagjja", destinacionet.Adresa.Lagjja);
                    cmd.Parameters.AddWithValue("@Rruga", destinacionet.Adresa.Rruga);
                    cmd.Parameters.AddWithValue("@InsertBy", destinacionet.Adresa.InsertBy);
                    cmd.Parameters.AddWithValue("@InsertDate", destinacionet.Adresa.InsertDate);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable SelectDestinacionet()
        {
            try
            {
                using (DatabaseConn.conn = new SqlConnection(DatabaseConn.conString))
                {
                    DatabaseConn.da = new SqlDataAdapter("usp_SelectDestinacionet", DatabaseConn.conn);
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
    }
}
