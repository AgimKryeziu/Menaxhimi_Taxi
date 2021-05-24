using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Taxi.BO;

namespace Taxi.DAL
{
    public class ShoferiDAL
    {
        public DataTable GetAllShofers()
        {
            try
            {
                using (DatabaseConn.conn = new SqlConnection(DatabaseConn.conString))
                {
                    DatabaseConn.da = new SqlDataAdapter("usp_ShowShoferat", DatabaseConn.conn);
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

        public bool InsertShofer(ShoferiBO shoferi)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConn.conString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_InsertShoferin", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Emri", shoferi.Emri);
                    cmd.Parameters.AddWithValue("@Mbiemri", shoferi.Mbiemri);
                    cmd.Parameters.AddWithValue("@Datelindja", shoferi.Datelindja);
                    cmd.Parameters.AddWithValue("@NrPersonal", shoferi.NrPersonal);
                    cmd.Parameters.AddWithValue("@NrTelefonit", shoferi.NrTelefonit);
                    cmd.Parameters.AddWithValue("@Gjinia", shoferi.Gjinia);
                    cmd.Parameters.AddWithValue("@Biografia", shoferi.Biografia);
                    cmd.Parameters.AddWithValue("@VitiNisjsPunes", shoferi.VitiNisjesPunes);
                    cmd.Parameters.AddWithValue("@InsertBy", shoferi.InsertBy);
                    cmd.Parameters.AddWithValue("@InsertDate", shoferi.InsertDate);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public ShoferiBO GetItemById(int id)
        {
            DataSet ds;
            ShoferiBO shoferiBO;
            try
            {
                using (DatabaseConn.conn = new SqlConnection(DatabaseConn.conString))
                {
                    DatabaseConn.conn.Open();
                    DatabaseConn.cmd = new SqlCommand("usp_GetShoferByID", DatabaseConn.conn);
                    DatabaseConn.cmd.CommandType = CommandType.StoredProcedure;

                    DatabaseConn.cmd.Parameters.AddWithValue("@ShoferiId", id);

                    DatabaseConn.da = new SqlDataAdapter(DatabaseConn.cmd);
                    ds = new DataSet();
                    DatabaseConn.da.Fill(ds);

                    string ShoferiId = Convert.ToString(ds.Tables[0].Rows[0]["ShoferiId"]);
                    string Emri = Convert.ToString(ds.Tables[0].Rows[0]["Emri"]);
                    string Mbiemri = Convert.ToString(ds.Tables[0].Rows[0]["Mbiemri"]);
                    string Datelindja = Convert.ToString(ds.Tables[0].Rows[0]["Datelindja"]);
                    string NrPersonal = Convert.ToString(ds.Tables[0].Rows[0]["NrPersonal"]);
                    string NrTelefonit = Convert.ToString(ds.Tables[0].Rows[0]["NrTelefonit"]);
                    string Gjinia = Convert.ToString(ds.Tables[0].Rows[0]["Gjinia"]);
                    string Biografia = Convert.ToString(ds.Tables[0].Rows[0]["Biografia"]);
                    string VitiNisjesPunes = Convert.ToString(ds.Tables[0].Rows[0]["VitiNisjesPunes"]);

                    shoferiBO = new ShoferiBO(Convert.ToInt32(ShoferiId), Emri, Mbiemri, Convert.ToDateTime(Datelindja), Convert.ToChar(Gjinia), NrPersonal, NrPersonal, Biografia, Convert.ToInt32(VitiNisjesPunes));
                    return shoferiBO;

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EditShofer(ShoferiBO shoferi)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConn.conString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_EditShofer", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ShoferiId", shoferi.IdPunes);
                    cmd.Parameters.AddWithValue("@Emri", shoferi.Emri);
                    cmd.Parameters.AddWithValue("@Mbiemri", shoferi.Mbiemri);
                    cmd.Parameters.AddWithValue("@Datelindja", shoferi.Datelindja);
                    cmd.Parameters.AddWithValue("@NrPersonal", shoferi.NrPersonal);
                    cmd.Parameters.AddWithValue("@NrTelefonit", shoferi.NrTelefonit);
                    cmd.Parameters.AddWithValue("@Gjinia", shoferi.Gjinia);
                    cmd.Parameters.AddWithValue("@Biografia", shoferi.Biografia);
                    cmd.Parameters.AddWithValue("@VitiNisjsPunes", shoferi.VitiNisjesPunes);
                    cmd.Parameters.AddWithValue("@LUB", 1);
                    cmd.Parameters.AddWithValue("@LUD", DateTime.Now);
                    cmd.Parameters.AddWithValue("@LUN", shoferi.LUN);

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
