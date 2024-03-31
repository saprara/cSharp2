using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Week10DisconnectModel
{
    /// <summary>
    /// Interaction logic for DataSetWithMulitpleTable.xaml
    /// </summary>
    public partial class DataSetWithMulitpleTable : Window
    {
        public DataSetWithMulitpleTable()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {
            string query = "SELECT * FROM CATEGORIES;SELECT * FROM PRODUCTS";
            SqlConnection conn =new SqlConnection(Data.ConnectionString);
            SqlDataAdapter adp = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            ds.Tables[0].
            Datagrd1.ItemsSource = ds.Tables[0].DefaultView;
            Datagrd2.ItemsSource = ds.Tables[1].DefaultView;
        }
    }
}
