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
            var ordersBindingSource = new BindingSource(dataSet, "Orders");
            ordersGridView.DataSource = ordersBindingSource;
        }

        private void MainWindow_Load(object sender, System.EventArgs e)
        {
            dataAdapter.OrdersDataAdapter.Fill(dataSet.Tables["Orders"]);
        }
    }
}