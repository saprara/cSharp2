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

namespace W5WpfControl
{
    /// <summary>
    /// Interaction logic for AddUC.xaml
    /// </summary>
    public partial class AddUC : Window
    {
        public AddUC()
        {
            InitializeComponent();
        }

       
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            string msg = " You order:\n";
            if(chk.IsChecked == true)
            {
                msg += "! "+chk.Content + "\n";
            }
            if (pepp.IsChecked == true)
            {
                msg += "! " + pepp.Content + "\n";
            }
            if (veg.IsChecked == true)
            {
                msg += "! " + veg.Content + "\n";
            }

            lbl.Content = msg;

        }

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string gender = "Gender selected is: \n";
            if(male.IsChecked == true)
            {
                gender += male.Content;
            }
           else if (female.IsChecked == true)
            {
                gender += female.Content;
            }
            else if (Others.IsChecked == true)
            {
                gender += Others.Content;
            }
            lbl1.Content = gender;

        }

        private void btn2_Click(object sender, RoutedEventArgs e)

        {
            string car = "you selected :";
           
            lbl2.Content = "you selected : "+Car.Text;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if()
:        }
    }
}
