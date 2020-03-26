using System.Data.SqlClient;
using DBMSLab.Properties;

namespace DBMSLab.database
{
    public class ElectronicsDatabaseConnector
    {
        private static SqlConnection connection;
        public static SqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(Settings.Default.Electronics_ShopConnectionString);
            }
            return connection;
        }
    }
}