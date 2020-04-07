using System.Configuration;
using System.Data;

namespace DBMSLab.database
{
    public class ElectronicsDataSet : DataSet
    {
        private ElectronicsDataSet()
        {
            
        }

        public static void addDataSetRelation(DataSet dataSet, string field1, string field2)
        {
            var customersTable = dataSet.Tables[ConfigurationManager.AppSettings["parentTable"]];
            var ordersTable = dataSet.Tables[ConfigurationManager.AppSettings["childTable"]];
            
            ordersTable.Constraints.Add(
                new ForeignKeyConstraint(customersTable.Columns[field1], ordersTable.Columns[field2])
            );
            
            var relation = new DataRelation(
                "ParentChild",
                customersTable.Columns[field1],
                ordersTable.Columns[field2]
            );
            dataSet.Relations.Add(relation);
        }
    }
}