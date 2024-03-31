using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Collections;
using System.Runtime.Intrinsics.Arm;

namespace Week10DisconnectModel
{
    public class Crud
    {
        private SqlConnection conn;
        private SqlDataAdapter adp;
        private SqlCommandBuilder cmdBuilder;
        private SqlDataReader reader;
        private DataSet ds;
        private DataTable tbl;




        public Crud()
        {
            String query = "SELECT ProductID,ProductName,UnitPrice,UnitsInStock FROM  Products";

            conn = new SqlConnection(Data.ConnectionString);
            adp = new SqlDataAdapter(query, conn);
            cmdBuilder = new SqlCommandBuilder(adp);

            FillDataSet();
        }
        private void FillDataSet()
        {
            ds = new DataSet();
            adp.Fill(ds);
            tbl = ds.Tables[0];

            DataColumn[] pk = new DataColumn[1];
            pk[0] = tbl.Columns["ProductID"];
            pk[0].AutoIncrement = true;
            tbl.PrimaryKey= pk;

        }

        public DataTable GetAllProducts() 
        { 
        FillDataSet();
            return tbl;
        
        
        }
        public DataRow GetProductByID(int id)
        {
            var row = tbl.Rows.Find(id);
            return row;
        }
        public void InsertProduct(string name, decimal price, short quantity)
        {
            var row = tbl.NewRow();
            row["ProductName"] = name;
            row["UnitPrice"] = price;
            row["UnitsInStock"]=quantity;
            tbl.Rows.Add(row);
            adp.InsertCommand = cmdBuilder.GetInsertCommand();
            adp.Update(tbl);FillDataSet();
        }
        public void UpdateProduct(int id ,string name, decimal price, short quantity)
        {
            var row = tbl.Rows.Find(id);
            row["ProductName"] = name;
            row["UnitPrice"] = price;
            row["UnitsInStock"] = quantity;
            
            adp.UpdateCommand = cmdBuilder.GetUpdateCommand();
            adp.Update(tbl); 
            FillDataSet();
        }
        public void DeleteProduct(int id)
        {
            var row = tbl.Rows.Find(id);
            row.Delete();


            adp.DeleteCommand = cmdBuilder.GetDeleteCommand();
            adp.Update(tbl);
            FillDataSet();
        }



    }
}
