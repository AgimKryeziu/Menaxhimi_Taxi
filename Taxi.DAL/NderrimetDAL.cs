using System;
using System.Data;
using System.Data.SqlClient;
using Taxi.BO;

namespace Taxi.DAL
{
    public class NderrimetDAL
    {
        public DataTable ShowNderrimet()
        {
            try
            {
                using (DatabaseConn.conn = new SqlConnection(DatabaseConn.conString))
                {
                    DatabaseConn.da = new SqlDataAdapter("usp_ShowNderrimet", DatabaseConn.conn);
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

        public bool InsertNderrim(NderrimetBO nderrimetBO)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConn.conString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_InsertNderrim", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ShoferiId", nderrimetBO.Shoferi.IdPunes);
                    cmd.Parameters.AddWithValue("@AutomjetiId", nderrimetBO.Automjeti.AutomjetiId);
                    cmd.Parameters.AddWithValue("@FillimiNderrimit", nderrimetBO.FillimiINderrimit);
                    cmd.Parameters.AddWithValue("@MbarimiINderrimit", nderrimetBO.MbarimiINDerrimit);
                    cmd.Parameters.AddWithValue("@InsertedBy", nderrimetBO.InsertBy);
                    cmd.Parameters.AddWithValue("@InsertDate", nderrimetBO.InsertDate);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public NderrimetBO GetItemById(int id)
        {
            DataSet ds;
            NderrimetBO nderrimetBO;
            AutomjetiBO automjetiBO;
            ShoferiBO shoferiBO;

            try
            {
                using (DatabaseConn.conn = new SqlConnection(DatabaseConn.conString))
                {
                    DatabaseConn.conn.Open();
                    DatabaseConn.cmd = new SqlCommand("usp_GetNderrimiByID", DatabaseConn.conn);
                    DatabaseConn.cmd.CommandType = CommandType.StoredProcedure;

                    DatabaseConn.cmd.Parameters.AddWithValue("@NderrimiId", id);

                    DatabaseConn.da = new SqlDataAdapter(DatabaseConn.cmd);
                    ds = new DataSet();
                    DatabaseConn.da.Fill(ds);

                    string nderrimiId = Convert.ToString(ds.Tables[0].Rows[0]["AutomjetiId"]);
                    string automjetId = Convert.ToString(ds.Tables[0].Rows[0]["AutomjetiId"]);
                    string shoferiId = Convert.ToString(ds.Tables[0].Rows[0]["ShoferiId"]);
                    string automjetiId = Convert.ToString(ds.Tables[0].Rows[0]["AutomjetiId"]);
                    string fillimiINderrimit = Convert.ToString(ds.Tables[0].Rows[0]["FillimiINdrrimit"]);
                    string mbarimiINderrimit = Convert.ToString(ds.Tables[0].Rows[0]["MbarimiINdrrimit"]);

                    automjetiBO = new AutomjetiBO(Int32.Parse(automjetId));
                    shoferiBO = new ShoferiBO(Int32.Parse(shoferiId));
                    nderrimetBO = new NderrimetBO(Int32.Parse(nderrimiId), shoferiBO, automjetiBO, Convert.ToDateTime(fillimiINderrimit), Convert.ToDateTime(mbarimiINderrimit));
                    return nderrimetBO;

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EditNderrim(NderrimetBO nderrimetBO)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConn.conString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_EditNderrim", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NderrimiId", nderrimetBO.Shoferi.IdPunes);
                    cmd.Parameters.AddWithValue("@ShoferiId", nderrimetBO.Shoferi.IdPunes);
                    cmd.Parameters.AddWithValue("@AutomjetiId", nderrimetBO.Automjeti.AutomjetiId);
                    cmd.Parameters.AddWithValue("@FillimiNderrimit", nderrimetBO.FillimiINderrimit);
                    cmd.Parameters.AddWithValue("@MbarimiINderrimit", nderrimetBO.MbarimiINDerrimit);
                    cmd.Parameters.AddWithValue("@LUB", nderrimetBO.LUB);
                    cmd.Parameters.AddWithValue("@LUD", DateTime.Now);
                    cmd.Parameters.AddWithValue("@LUN", nderrimetBO.LUN);

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
                    SqlCommand cmd = new SqlCommand("usp_DeleteNderrim", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NderrimiId", id);

                    cmd.ExecuteNonQuery();
                }
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable SelectNderrimet()
        {
            try
            {
                using (DatabaseConn.conn = new SqlConnection(DatabaseConn.conString))
                {
                    DatabaseConn.da = new SqlDataAdapter("usp_SelectNderrimet", DatabaseConn.conn);
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
