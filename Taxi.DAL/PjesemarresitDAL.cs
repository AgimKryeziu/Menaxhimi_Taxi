using System;
using System.Data;
using System.Data.SqlClient;
using Taxi.BO;

namespace Taxi.DAL
{
    public class PjesemarresitDAL
    {
        public static bool CheckLogInConfig(string username, string password)
        {
            bool gjendja = false;
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
                        passwordi = dt.Rows[0][1].ToString();
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

        public PjesemarresitBO GetItemById(int id)
        {
            DataSet ds;
            PjesemarresitBO pjesemarresitBO;

            try
            {
                using (DatabaseConn.conn = new SqlConnection(DatabaseConn.conString))
                {
                    DatabaseConn.conn.Open();
                    DatabaseConn.cmd = new SqlCommand("usp_GetAdminByID", DatabaseConn.conn);
                    DatabaseConn.cmd.CommandType = CommandType.StoredProcedure;

                    DatabaseConn.cmd.Parameters.AddWithValue("@PmID", id);

                    DatabaseConn.da = new SqlDataAdapter(DatabaseConn.cmd);
                    ds = new DataSet();
                    DatabaseConn.da.Fill(ds);

                    string adminId = Convert.ToString(ds.Tables[0].Rows[0]["PmID"]);
                    string pershkrimiId = Convert.ToString(ds.Tables[0].Rows[0]["RoliID"]);
                    string emri = Convert.ToString(ds.Tables[0].Rows[0]["Emri"]);
                    string mbiemri = Convert.ToString(ds.Tables[0].Rows[0]["Mbiemri"]);
                    string nrTel = Convert.ToString(ds.Tables[0].Rows[0]["NrTel"]);
                    string email = Convert.ToString(ds.Tables[0].Rows[0]["Email"]);
                    string nofka = Convert.ToString(ds.Tables[0].Rows[0]["UserName"]);
                    string fjalekalimi = Convert.ToString(ds.Tables[0].Rows[0]["Passwordi"]);

                    RoletBO roletBO = new RoletBO(int.Parse(pershkrimiId));
                    pjesemarresitBO = new PjesemarresitBO(int.Parse(adminId), roletBO, emri, mbiemri, nrTel, email, nofka, fjalekalimi);
                    return pjesemarresitBO;

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EditAdmin(PjesemarresitBO pjesemarresitBO)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConn.conString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_EditAdmin", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@PmId", pjesemarresitBO.PmId);

                    cmd.Parameters.AddWithValue("@LUB", pjesemarresitBO.LUB);
                    cmd.Parameters.AddWithValue("@LUD", DateTime.Now);
                    cmd.Parameters.AddWithValue("@LUN", pjesemarresitBO.LUN);

                    cmd.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteItem(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConn.conString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_DeleteAdmin", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@PmId", id);

                    cmd.ExecuteNonQuery();
                }
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
