using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Data;
using System.Data.SqlClient;
using W11TYpesDataSets.DataSet1TableAdapters;

namespace W11TYpesDataSets
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataSet1TableAdapters.ProductsTableAdapter adpProducts = new DataSet1TableAdapters.ProductsTableAdapter();
        DataSet1.ProductsDataTable tblProducts = new DataSet1.ProductsDataTable();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLoadAllProducts_Click(object sender, RoutedEventArgs e)
        {
            adpProducts.Fill(tblProducts);
            grdProducts.ItemsSource = tblProducts;
        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var row = tblProducts.FindByProductID(id);
            if (row != null)
            {
                txtName.Text = row.ProductName;
                txtPrice.Text = row.UnitPrice.ToString();
                txtQuantity.Text = row.UnitPrice.ToString();

            }
            else
                MessageBox.Show("Item not found");
        }
    }
}