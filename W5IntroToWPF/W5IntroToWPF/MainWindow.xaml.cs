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

namespace W5IntroToWPF
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

        private void ClickMeButton_Click(object sender, RoutedEventArgs e)
        {
            string name = UserName.Text;
            MessageBox.Show("Hello "+ name);
        }

        private void UserName_GotFocus(object sender, RoutedEventArgs e)
        {
            UserName.Background = Brushes.LightBlue;
        }

        private void UserName_LostFocus(object sender, RoutedEventArgs e)
        {
            UserName.Background = Brushes.White;
        }

        /* private void ClickMeButton_Click(object sender, RoutedEventArgs e)
         {
           var result=  MessageBox.Show("Hello World","Message box" ,MessageBoxButton.YesNo,MessageBoxImage.Warning);
             if(result == MessageBoxResult.Yes)
             {

             }

         }*/



    }
}