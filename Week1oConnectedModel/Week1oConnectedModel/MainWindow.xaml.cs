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
using System.Data.SqlClient;
using System.Data;

namespace Week1oConnectedModel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            using (SqlConnection conn = new SqlConnection(Data.ConnectionString))
            {

                string query = "select EmployeeID, FirstName, LastName, City from Employees";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                DataTable tbl = new DataTable();
                tbl.Load(reader);
                grdEmployees.ItemsSource = tbl.DefaultView;
            }
            //conn.Close();

        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            loadData();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //string concatenation - bad way
            //string query= "SELECT EmployeeID, FirstName, LastName, City, Country\r\n                " +
            //    " FROM Employees WHERE FirstName = '" + txtFirstname.Text+"'";




            //parameterized query - better way


            string query = "SELECT EmployeeID, FirstName, LastName, City, Country\r\n " +
                "FROM Employees WHERE FirstName = @FirstName";
            using (SqlConnection conn = new SqlConnection(Data.ConnectionString))
            {

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("Firstname", txtFirstname.Text);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                DataTable tbl = new DataTable();
                tbl.Load(reader);
                grdEmployees.ItemsSource = tbl.DefaultView;
            }
        }

        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            string query = "Select Count(*) from Employees";
            using (SqlConnection conn = new SqlConnection(Data.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int numOfRows = (int)cmd.ExecuteScalar();
                MessageBox.Show("Number of rows: " + numOfRows);
            }
        }


        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            string query = "Insert into Employees (LastName, FirstName) values (@LastName, @FirstName)";
            using (SqlConnection conn = new SqlConnection(Data.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("LastName", txtLastname.Text);
                cmd.Parameters.AddWithValue("FirstName", txtFirstname.Text);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                    MessageBox.Show("Employee inserted");
                else
                    MessageBox.Show("Employee not inserted");
            }
        }

    }
}
