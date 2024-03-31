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

namespace w6MidTermReview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Employee> Employees;
        public MainWindow()
        {
            InitializeComponent();
            Employees = new List<Employee>()
            {
                new Employee (101,"John","Toronto"),
                new Employee(102,"jack","Moscow"),
                new Employee(103,"jon","Paris"),
                new Employee(104,"Sam","Berlin"),
                new Employee(105,"James","Budapest")
            };
        }
        private void RefreshListBox()
        {
            var names=from emp in Employees
                      select emp.Name;
            ListBox.ItemsSource = names;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshListBox();
            grdEmployees.ItemsSource= Employees;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ListBox.SelectedItem != null)
            {
                Employee emp = Employees[ListBox.SelectedIndex];
                IdtextBox.Text=emp.Id.ToString();
                NameTextBox.Text=emp.Name.ToString();
                CityTextBox.Text=emp.City.ToString();   
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            int id = 101;
            if (Employees.Count > 0) { 
            id= Employees.Last().Id+1;
            }
           // int id = int.Parse(IdtextBox.Text);
            string name = NameTextBox.Text;
            string city = CityTextBox.Text;

            Employee emp =new Employee(id, name, city);
            Employees.Add(emp);
            IdtextBox.Text=id.ToString();
            RefreshListBox();
            MessageBox.Show("New Employee added");
            
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Employee emp = Employees[ListBox.SelectedIndex];
            emp.Name = NameTextBox.Text;
            emp.City = CityTextBox.Text;
            RefreshListBox();
            MessageBox.Show("Employee Information Updated");
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Employee emp = Employees[ListBox.SelectedIndex];
            Employees.Remove(emp);
            RefreshListBox();
            IdtextBox.Text = NameTextBox.Text = CityTextBox.Text = "";
            MessageBox.Show("Employee deleted");

        }

        

        private void Findbtn_Click(object sender, RoutedEventArgs e)
        {
            NameTextBox.Text = "";
            CityTextBox.Text = "";
            int id =int.Parse(IdtextBox.Text);
            var emp = (from em in Employees
                       where em.Id == id
                       select em).FirstOrDefault();
            if (emp != null)
            {
                NameTextBox.Text = emp.Name;
                CityTextBox.Text = emp.City;
            }
            else
                MessageBox.Show("invalid id");
            

        }
    }
}