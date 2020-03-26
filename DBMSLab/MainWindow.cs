using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DBMSLab.database;

namespace DBMSLab
{
    public partial class MainWindow : Form
    {
        private ElectronicsDataSet dataSet;
        private ElectronicsDataAdapter dataAdapter;

        public MainWindow()
        {
            InitializeComponent();
            dataSet = new ElectronicsDataSet();
            dataAdapter = new ElectronicsDataAdapter();
            var customersBindingSource = new BindingSource(dataSet, "Customers");
            var ordersBindingSource = new BindingSource(customersBindingSource, "CustomerOrders");
            customersGridView.DataSource = customersBindingSource;
            ordersGridView.DataSource = ordersBindingSource;
        }

        private void MainWindow_Load(object sender, System.EventArgs e)
        {
            try
            {
                dataAdapter.CustomersDataAdapter.Fill(dataSet.Tables["Customers"]);
                dataAdapter.OrdersDataAdapter.Fill(dataSet.Tables["Orders"]);
            }
            catch (SqlException exception)
            {
                MessageBox.Show("There was an error communicating with the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataAdapter.OrdersDataAdapter.Update(dataSet, "Orders");
                dataAdapter.OrdersDataAdapter.Fill(dataSet, "Orders");
                changesLabel.Visible = true;
            }
            catch (SqlException exception)
            {
                MessageBox.Show("There was an error communicating with the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}