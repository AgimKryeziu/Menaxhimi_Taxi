using System;
using System.Data;
using System.Data.SqlClient;
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

                    cmd.Parameters.AddWithValue("@Targa", automjeti.Targa);
                    cmd.Parameters.AddWithValue("@ModeliId", automjeti.Modelet.ModeliId);
                    cmd.Parameters.AddWithValue("@VitiIProdhimit", automjeti.VitiIProdhimit);
                    cmd.Parameters.AddWithValue("@Kilometrat", automjeti.Km);
                    cmd.Parameters.AddWithValue("@Aktiv", automjeti.Aktiv);
                    cmd.Parameters.AddWithValue("@InsertedBy", automjeti.InsertBy);
                    cmd.Parameters.AddWithValue("@InsertDate", automjeti.InsertDate);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public AutomjetiBO GetItemById(int id)
        {
            DataSet ds;
            AutomjetiBO automjeti;
            ModeletBO modeletBO;

            try
            {
                using (DatabaseConn.conn = new SqlConnection(DatabaseConn.conString))
                {
                    DatabaseConn.conn.Open();
                    DatabaseConn.cmd = new SqlCommand("usp_GetAutomjetByID", DatabaseConn.conn);
                    DatabaseConn.cmd.CommandType = CommandType.StoredProcedure;

                    DatabaseConn.cmd.Parameters.AddWithValue("@AutomjetiId", id);

                    DatabaseConn.da = new SqlDataAdapter(DatabaseConn.cmd);
                    ds = new DataSet();
                    DatabaseConn.da.Fill(ds);

                    string automjetId = Convert.ToString(ds.Tables[0].Rows[0]["AutomjetiId"]);
                    string targa = Convert.ToString(ds.Tables[0].Rows[0]["Targa"]);
                    string modeliId = Convert.ToString(ds.Tables[0].Rows[0]["ModeliId"]);
                    string vitiIProdhimit = Convert.ToString(ds.Tables[0].Rows[0]["VitiIProdhimit"]);
                    string aktiv = Convert.ToString(ds.Tables[0].Rows[0]["Aktiv"]);
                    string kilometrat = Convert.ToString(ds.Tables[0].Rows[0]["Kilometrat"]);

                    modeletBO = new ModeletBO(Int32.Parse(modeliId));
                    automjeti = new AutomjetiBO(Int32.Parse(automjetId), modeletBO, targa, Int32.Parse(vitiIProdhimit), Convert.ToBoolean(aktiv), Convert.ToDouble(kilometrat));
                    return automjeti;

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EditAutomjet(AutomjetiBO automjeti)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConn.conString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_EditAutomjet", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@AutomjetiId", automjeti.AutomjetiId);
                    cmd.Parameters.AddWithValue("@Targa", automjeti.Targa);
                    cmd.Parameters.AddWithValue("@ModeliId", automjeti.Modelet.ModeliId);
                    cmd.Parameters.AddWithValue("@VitiIProdhimit", automjeti.VitiIProdhimit);
                    cmd.Parameters.AddWithValue("@Kilimetrat", automjeti.Km);
                    cmd.Parameters.AddWithValue("@Aktiv", automjeti.Aktiv);
                    cmd.Parameters.AddWithValue("@LUB", automjeti.LUB);
                    cmd.Parameters.AddWithValue("@LUD", DateTime.Now);
                    cmd.Parameters.AddWithValue("@LUN", automjeti.LUN);

                    cmd.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception)
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
                    SqlCommand cmd = new SqlCommand("usp_DeleteAutomjet", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@AutomjetiId", id);

                    cmd.ExecuteNonQuery();
                }
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable SelectCab()
        {
            try
            {
                using (DatabaseConn.conn = new SqlConnection(DatabaseConn.conString))
                {
                    DatabaseConn.da = new SqlDataAdapter("usp_SelectCab", DatabaseConn.conn);
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
