using System.Windows.Forms;

namespace DBMSLab
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void reservationsBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            this.reservationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.electronics_ShopDataSet);

        }

        private void MainWindow_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'electronics_ShopDataSet.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.electronics_ShopDataSet.Reservations);

        }
    }
}