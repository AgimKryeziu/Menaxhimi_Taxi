using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.BO;

namespace Taxi.DAL
{
    class DestinacioniDALcs
    {
        public bool InsertShofer(DestinacionetBO destinacionet)
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
    }
}
