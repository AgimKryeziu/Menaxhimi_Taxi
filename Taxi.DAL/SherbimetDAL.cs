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
    public class SherbimetDAL
    {
        public DataTable GetAllServices()
        {
            try
            {
                using (DatabaseConn.conn = new SqlConnection(DatabaseConn.conString))
                {
                    DatabaseConn.da = new SqlDataAdapter("usp_ShowServices", DatabaseConn.conn);
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

        public SherbimetBO GetItemById(int id)
        {
            DataSet ds;
            SherbimetBO sherbimetBO;
            NderrimetBO nderrimetBO;
            DestinacioniBO destinacioniBO;
            try
            {
                using (DatabaseConn.conn = new SqlConnection(DatabaseConn.conString))
                {
                    DatabaseConn.conn.Open();
                    DatabaseConn.cmd = new SqlCommand("usp_GetServiceByID", DatabaseConn.conn);
                    DatabaseConn.cmd.CommandType = CommandType.StoredProcedure;

                    DatabaseConn.cmd.Parameters.AddWithValue("@SherbimiId", id);

                    DatabaseConn.da = new SqlDataAdapter(DatabaseConn.cmd);
                    ds = new DataSet();
                    DatabaseConn.da.Fill(ds);

                    string sherbimiId = Convert.ToString(ds.Tables[0].Rows[0]["SherbimiId"]);
                    string nderrimiId = Convert.ToString(ds.Tables[0].Rows[0]["NderrimiId"]);
                    string kohaENisjes = Convert.ToString(ds.Tables[0].Rows[0]["KohaENisjes"]);
                    string vendtakimi = Convert.ToString(ds.Tables[0].Rows[0]["Vendtakimi"]);
                    string destinacioniId = Convert.ToString(ds.Tables[0].Rows[0]["DestinacioniId"]);
                    string distanca = Convert.ToString(ds.Tables[0].Rows[0]["Distanca"]);
                    string kohaEMberritjes = Convert.ToString(ds.Tables[0].Rows[0]["KohaEMberritjes"]);
                    string anulohet = Convert.ToString(ds.Tables[0].Rows[0]["Anulohet"]);
                    
                    nderrimetBO = new NderrimetBO(int.Parse(nderrimiId));
                    destinacioniBO = new DestinacioniBO(int.Parse(destinacioniId));
                    sherbimetBO = new SherbimetBO(Convert.ToInt32(sherbimiId),nderrimetBO, Convert.ToDateTime(kohaENisjes), vendtakimi, destinacioniBO, Convert.ToDateTime(kohaEMberritjes), Convert.ToDouble(distanca), Convert.ToBoolean(anulohet));
                    return sherbimetBO;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertService(SherbimetBO sherbimetBO)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConn.conString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_InsertService", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NderrimiId", sherbimetBO.Ndrrimet.NderrimiId);
                    cmd.Parameters.AddWithValue("@KohaENisjes", sherbimetBO.KohaNisjes);
                    cmd.Parameters.AddWithValue("@Vendtakimi", sherbimetBO.Vendtakimi);
                    cmd.Parameters.AddWithValue("@DestinacioniId", sherbimetBO.Destinacioni.DestinacioniId);
                    cmd.Parameters.AddWithValue("@Distanca", sherbimetBO.Distanca);
                    cmd.Parameters.AddWithValue("@KohaEMberritjes", sherbimetBO.KohaEMberritjes);
                    cmd.Parameters.AddWithValue("@Anulohet", sherbimetBO.Anulohet);
                    cmd.Parameters.AddWithValue("@InsertBy", sherbimetBO.InsertBy);
                    cmd.Parameters.AddWithValue("@InsertDate", sherbimetBO.InsertDate);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EditService(SherbimetBO sherbimetBO)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConn.conString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_EditService", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@SherbimiId", sherbimetBO.SherbimiId);
                    cmd.Parameters.AddWithValue("@NderrimiId", sherbimetBO.Ndrrimet.NderrimiId);
                    cmd.Parameters.AddWithValue("@KohaENisjes", sherbimetBO.KohaNisjes);
                    cmd.Parameters.AddWithValue("@Vendtakimi", sherbimetBO.Vendtakimi);
                    cmd.Parameters.AddWithValue("@DestinacioniId", sherbimetBO.Destinacioni.DestinacioniId);
                    cmd.Parameters.AddWithValue("@Distanca", sherbimetBO.Distanca);
                    cmd.Parameters.AddWithValue("@KohaEMberritjes", sherbimetBO.KohaEMberritjes);
                    cmd.Parameters.AddWithValue("@Anulohet", sherbimetBO.Anulohet);
                    cmd.Parameters.AddWithValue("@LUB", sherbimetBO.LUB);
                    cmd.Parameters.AddWithValue("@LUD", DateTime.Now);
                    cmd.Parameters.AddWithValue("@LUN", sherbimetBO.LUN);

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
