using System.Data;
using System.Data.SqlClient;

namespace DBMSLab.database
{
    public class ElectronicsDataAdapter
    {
        public SqlDataAdapter OrdersDataAdapter;
        public SqlDataAdapter CustomersDataAdapter;

        public ElectronicsDataAdapter()
        {
            CustomersDataAdapter = new SqlDataAdapter();

            SqlCommand customersSelectCommand = new SqlCommand(
                "SELECT customer_id, name, fidelity_points, email FROM Customers",
                ElectronicsDatabaseConnector.GetConnection()
            );

            CustomersDataAdapter.SelectCommand = customersSelectCommand;

            OrdersDataAdapter = new SqlDataAdapter();
            OrdersDataAdapter.SelectCommand = new SqlCommand(
                "SELECT order_id, customer_id, date, employee_helper_id, progress FROM Orders",
                ElectronicsDatabaseConnector.GetConnection()
            );

            OrdersDataAdapter.InsertCommand = new SqlCommand(
                "INSERT INTO Orders (customer_id, date, employee_helper_id, progress) VALUES (@customer_id, @date, @employee_helper_id, @progress)",
                ElectronicsDatabaseConnector.GetConnection()
            );
            // OrdersDataAdapter.InsertCommand.Parameters.Add("@order_id", SqlDbType.Int, 100, "order_id");
            OrdersDataAdapter.InsertCommand.Parameters.Add("@customer_id", SqlDbType.Int, 100, "customer_id");
            OrdersDataAdapter.InsertCommand.Parameters.Add("@date", SqlDbType.DateTime, 100, "date");
            OrdersDataAdapter.InsertCommand.Parameters.Add("@employee_helper_id", SqlDbType.Int, 100, "employee_helper_id");
            OrdersDataAdapter.InsertCommand.Parameters.Add("@progress", SqlDbType.NVarChar, 1000, "progress");

            OrdersDataAdapter.UpdateCommand = new SqlCommand(
                "UPDATE Orders SET customer_id=@customer_id, date=@date, employee_helper_id=@employee_helper_id, progress=@progress WHERE order_id=@order_id",
                ElectronicsDatabaseConnector.GetConnection()
            );
            
            OrdersDataAdapter.UpdateCommand.Parameters.Add("@order_id", SqlDbType.Int, 100, "order_id");
            OrdersDataAdapter.UpdateCommand.Parameters.Add("@customer_id", SqlDbType.Int, 100, "customer_id");
            OrdersDataAdapter.UpdateCommand.Parameters.Add("@date", SqlDbType.DateTime, 100, "date");
            OrdersDataAdapter.UpdateCommand.Parameters.Add("@employee_helper_id", SqlDbType.Int, 100, "employee_helper_id");
            OrdersDataAdapter.UpdateCommand.Parameters.Add("@progress", SqlDbType.NVarChar, 1000, "progress");

            OrdersDataAdapter.DeleteCommand = new SqlCommand(
                "DELETE FROM Orders WHERE order_id=@order_id",
                ElectronicsDatabaseConnector.GetConnection()
            );
            OrdersDataAdapter.DeleteCommand.Parameters.Add("@order_id", SqlDbType.Int, 100, "order_id");
        }
    }
}