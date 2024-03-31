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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace W11DBFirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            SchoolDBEntities db = new SchoolDBEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            //var students = db.Students.ToList();

            var students = from std in db.Students
                           select new { std.StudentID, std.StudentName, std.Standard.StandardName };





            grdStudents.ItemsSource = students.ToList();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var standards=db.Standards.ToList();
            cmbStandard.ItemsSource=standards;
            cmbStandard.DisplayMemberPath = "StandardName";
            cmbStandard.SelectedValuePath = "StandardId";
        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            int id =int.Parse(txtId.Text);
            var std = db.Students.Find(id);if (std != null)
            {
                txtName.Text = std.StudentName;
                cmbStandard.SelectedValue = std.StandardId;
            }
            else
                MessageBox.Show("ID not Found!");
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            Student std = new Student();
            std.StudentName = txtName.Text;
            std.StandardId =(int)cmbStandard.SelectedValue;

            db.Students.Add(std);
            db.SaveChanges();

            grdStudents.ItemsSource=db.Students.ToList();
            MessageBox.Show("New Student Added!");

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var std = db.Students.Find(id);
            if (std != null)
            {
                std.StudentName = txtName.Text;
                std.StandardId = (int)cmbStandard.SelectedValue;


                db.SaveChanges();
                grdStudents.ItemsSource = db.Students.ToList();
                MessageBox.Show("Student  Information Updated!");
            }
            else
                MessageBox.Show("Student Not found");

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var std = db.Students.Find(id);
            if (std != null)
            {
              db.Students.Remove(std);


                db.SaveChanges();
                grdStudents.ItemsSource = db.Students.ToList();
                MessageBox.Show("Student Deleted!");
            }
            else
                MessageBox.Show("Student Not found");
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //query
            
            //var students = from std in db.Students
            //               where std.StudentName.Contains(txtName.Text)
            //               select std;

            //method
            var students = db.Students.Where(std => std.StudentName.Contains(txtName.Text)).ToList();

            grdStudents.ItemsSource=students;
        }
    }
}
