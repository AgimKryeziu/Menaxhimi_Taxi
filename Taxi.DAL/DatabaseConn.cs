using System.Configuration;
using System.Data.SqlClient;

namespace Taxi.DAL
{
    class DatabaseConn
    {
        public static string conString = ConfigurationManager.ConnectionStrings["connStringTaxi"].ConnectionString.ToString();

        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
    }
}
