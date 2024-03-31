using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Week10DisconnectModel
{
    public class Data
    {
        public static string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
            "Integrated Security=True";
        public static string ConnectionString { get { return connStr; } }
        public DataTable GetAllProducts()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            String query = "SELECT ProductID,ProductName,UnitPrice,UnitsInStock FROM  Products";
            SqlDataAdapter adp = new SqlDataAdapter(query,conn);

            DataSet ds = new DataSet();
            adp.Fill(ds,"Products");

            DataTable tbl = ds.Tables["Products"]; 
            return tbl;
        }


    }
}
