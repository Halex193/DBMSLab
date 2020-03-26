using System;
using System.Data;

namespace DBMSLab.database
{
    public class ElectronicsDataSet : DataSet
    {
        public ElectronicsDataSet()
        {
            var ordersTable = new DataTable("Orders");
            ordersTable.Columns.Add("order_id", typeof(int));
            ordersTable.Columns.Add("customer_id", typeof(int));
            ordersTable.Columns.Add("date", typeof(DateTime));
            ordersTable.Columns.Add("employee_helper_id", typeof(int));
            ordersTable.Columns.Add("progress", typeof(string));
            Tables.Add(ordersTable);

            var customersTable = new DataTable("Customers");
            customersTable.Columns.Add("customer_id", typeof(int));
            customersTable.Columns.Add("name", typeof(string));
            customersTable.Columns.Add("fidelity_points", typeof(int));
            customersTable.Columns.Add("email", typeof(string));
            Tables.Add(customersTable);

            var relation = new DataRelation(
                "CustomerOrders",
                customersTable.Columns["customer_id"],
                ordersTable.Columns["customer_id"]
            );
            // Relations.Add(relation);
        }
    }
}