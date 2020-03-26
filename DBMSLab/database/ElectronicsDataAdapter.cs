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
            OrdersDataAdapter = new SqlDataAdapter();
            SqlCommand ordersSelectCommand = new SqlCommand(
                "SELECT order_id, customer_id, date, employee_helper_id, progress FROM Orders",
                ElectronicsDatabaseConnector.GetConnection()
            );
            OrdersDataAdapter.SelectCommand = ordersSelectCommand;

            CustomersDataAdapter = new SqlDataAdapter();

            SqlCommand customersSelectCommand = new SqlCommand(
                "SELECT customer_id, name, fidelity_points, email FROM Customers",
                ElectronicsDatabaseConnector.GetConnection()
            );
            
            SqlCommand customersInsertCommand = new SqlCommand(
                "INSERT INTO Customers (customer_id, name, fidelity_points, email) VALUES (@customer_id, @name, @fidelity_points, @email)",
                ElectronicsDatabaseConnector.GetConnection()
            );
            customersInsertCommand.Parameters.Add("@customer_id", SqlDbType.Int);
            customersInsertCommand.Parameters.Add("@name", SqlDbType.NVarChar);
            customersInsertCommand.Parameters.Add("@fidelity_points", SqlDbType.Int);
            customersInsertCommand.Parameters.Add("@email", SqlDbType.NVarChar);
            
            SqlCommand customersUpdateCommand = new SqlCommand(
                "UPDATE Customers SET (name = @name, fidelity_points = @fidelity_points, email = @email) WHERE customer_id = @customer_id",
                ElectronicsDatabaseConnector.GetConnection()
            );
            customersUpdateCommand.Parameters.Add("@customer_id", SqlDbType.Int);
            customersUpdateCommand.Parameters.Add("@name", SqlDbType.NVarChar);
            customersUpdateCommand.Parameters.Add("@fidelity_points", SqlDbType.Int);
            customersUpdateCommand.Parameters.Add("@email", SqlDbType.NVarChar);
            
            SqlCommand customersDeleteCommand = new SqlCommand(
                "DELETE FROM Customers WHERE customer_id = @customer_id",
                ElectronicsDatabaseConnector.GetConnection()
            );
            customersDeleteCommand.Parameters.Add("@customer_id", SqlDbType.Int);

            CustomersDataAdapter.SelectCommand = customersSelectCommand;
            CustomersDataAdapter.DeleteCommand = customersDeleteCommand;
            CustomersDataAdapter.InsertCommand = customersInsertCommand;
            CustomersDataAdapter.UpdateCommand = customersUpdateCommand;
        }
    }
}