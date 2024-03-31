﻿using System.Data;
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

namespace Week10DisconnectModel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Data data = new Data();
        Crud crud = new Crud();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLoadAllProducts_Click(object sender, RoutedEventArgs e)
        {
            //grdProducts.ItemsSource=data.GetAllProducts().DefaultView;
            grdProducts.ItemsSource = crud.GetAllProducts().DefaultView;

        }

        private void btnShowWindow2_Click(object sender, RoutedEventArgs e)
        {
            DataSetWithMulitpleTable win2=new DataSetWithMulitpleTable();
            win2.ShowDialog();
        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            DataRow row = crud.GetProductByID(id);

            if (row != null)
            {
                txtName.Text = row["ProductName"].ToString();
                txtPrice.Text = row["UnitPrice"].ToString();
                txtQuantity.Text = row["UnitsInStock"].ToString();
            }
            else
                MessageBox.Show("Invalid Product ID. Please try again.");
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            string name =txtName.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            short quantity= short.Parse(txtQuantity.Text);
            crud.InsertProduct(name, price, quantity);
            grdProducts.ItemsSource=crud.GetAllProducts().DefaultView;
            MessageBox.Show("Insert done");
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int id =int.Parse(txtId.Text);
            string name = txtName.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            short quantity = short.Parse(txtQuantity.Text);
            crud.UpdateProduct(id,name, price, quantity);
            grdProducts.ItemsSource = crud.GetAllProducts().DefaultView;
            MessageBox.Show("Update  done");
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            crud.DeleteProduct(id);
            grdProducts.ItemsSource = crud.GetAllProducts().DefaultView;
            MessageBox.Show("Delete done");

        }
    }
}