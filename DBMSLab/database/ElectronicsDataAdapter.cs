using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DBMSLab.database
{
    public class ElectronicsDataAdapter
    {
        public SqlDataAdapter ChildAdapter;
        public SqlDataAdapter ParentAdapter;

        public ElectronicsDataAdapter()
        {
            ParentAdapter = new SqlDataAdapter(ConfigurationManager.AppSettings["parentSelect"],
                ElectronicsDatabaseConnector.GetConnection());
            
            ChildAdapter = new SqlDataAdapter(
                ConfigurationManager.AppSettings["childSelect"],
                ElectronicsDatabaseConnector.GetConnection());
        }
    }
}