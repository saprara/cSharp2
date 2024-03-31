using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1oConnectedModel
{
    public class Data
    {
        public static string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Northwind;" +
            "Integrated Security=True";
        public static string ConnectionString { get { return connStr; } }
    }
}
