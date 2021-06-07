using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.BO;

namespace Taxi.DAL
{
    public class PjesemarresitDAL
    {

        public static bool CheckLogInConfig(string username, string password)
        {
            bool gjendja =false ;
            try
            {
                using (DatabaseConn.conn = new SqlConnection(DatabaseConn.conString))
                {
                    DataTable dt = new DataTable();

                    DatabaseConn.da = new SqlDataAdapter("usp_LoginRole", DatabaseConn.conn);
                    DatabaseConn.da.Fill(dt);
                    string IdRecord = "";
                    string passwordi = ""; 
                 
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                     IdRecord = dt.Rows[i][0].ToString();
                     passwordi = dt.Rows[i][0].ToString();
                        Console.WriteLine(passwordi);
                        if (IdRecord.Equals(username) && passwordi.Equals(password))
                        {
                          gjendja = true;
                           
                        }
                    }
                   
                }
                return gjendja;
            }
            catch (Exception)
            {
                return gjendja;
            }

            
        }

        public DataTable GetAllAdmin()
        {
            try
            {
                using (DatabaseConn.conn = new SqlConnection(DatabaseConn.conString))
                {
                    DatabaseConn.da = new SqlDataAdapter("usp_ShowAdmin", DatabaseConn.conn);
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

        public bool InsertAdmin(PjesemarresitBO pjesemarresitBO)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConn.conString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_InsertAdmin", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RoliId", pjesemarresitBO.RoletBO.RoliId);
                    cmd.Parameters.AddWithValue("@Emri", pjesemarresitBO.Emri);
                    cmd.Parameters.AddWithValue("@Mbiemri", pjesemarresitBO.Mbiemri);
                    cmd.Parameters.AddWithValue("@NrTel", pjesemarresitBO.NrTelefonit);
                    cmd.Parameters.AddWithValue("@Email", pjesemarresitBO.Email);
                    cmd.Parameters.AddWithValue("@UserName", pjesemarresitBO.Username);
                    cmd.Parameters.AddWithValue("@Passwordi", pjesemarresitBO.Password);
                    cmd.Parameters.AddWithValue("@InsertedBy", pjesemarresitBO.InsertBy);
                    cmd.Parameters.AddWithValue("@InsertDate", pjesemarresitBO.InsertDate);

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
    } 
}
