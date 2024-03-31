using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

namespace MTYRakshitSapra
{
    public partial class MainWindow : Window
    {
        List<Vehicle> list = new List<Vehicle>();


        public MainWindow()
        {
            InitializeComponent();
            Car car = new Car(1, "Toyota", "Corolla", 2015, "Black", 4, 5, false);
            list.Add(car);

            
            ElectricCar electricCar = new ElectricCar(2, "Tesla", "Model S", 2020, "White", 4, 5, false, 75.0);
            list.Add(electricCar);

            
            Truck truck = new Truck(3, "Ford", "Truck", 2018, "White", 4, 10000);
            list.Add(truck);
            if (string.IsNullOrWhiteSpace(VehicleIdTextBox.Text))
            {
                FindButton.IsEnabled = false;
            }
            else
            {
                FindButton.IsEnabled = true;
            }

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = list
                    .Where(v => v.GetType() == typeof(Car))
                    .Select(c => new { c.Make, c.Model, c.ManufactureYear, c.Color, ((Car)c).NumberOfDoors, ((Car)c).NumberOfSeats })
                    .ToList();
            

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = list
       .Where(v => v.GetType() == typeof(ElectricCar))
       .Select(ec => (ElectricCar)ec)
       .ToList();
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = list
    .Where(v => v.GetType() == typeof(Truck))
    .Select(t => (Truck)t)
    .ToList();
        }

        private void FindButton_Click(object sender, RoutedEventArgs e)
        {

            int vehicleId;
            if (int.TryParse(VehicleIdTextBox.Text, out vehicleId))
            {
                Vehicle foundVehicle = list.FirstOrDefault(v => v.Id == vehicleId);
                if (foundVehicle != null)
                {
                    
                    MakeLabel.Text = foundVehicle.Make;
                    ModelLabel.Text = foundVehicle.Model;
                    YearLabel.Text = foundVehicle.ManufactureYear.ToString();
                    ColorLabel.Text = foundVehicle.Color;

                    switch (foundVehicle)
                    {
                        case Car car when !(foundVehicle is ElectricCar):
                            NumberOfDoorsLabel.Text = car.NumberOfDoors.ToString();
                            NumberOfSeatsLabel.Text = car.NumberOfSeats.ToString();
                            BatteryCapacityLabel.Visibility = Visibility.Collapsed;
                            BC.Visibility = Visibility.Collapsed;
                            IsConvertibleCheckBox.IsChecked = car.IsConvertible;
                            AnnualInsuranceCostLabel.Text = car.getAnnualInsurance().ToString();
                            break;
                        case ElectricCar electricCar:
                            NumberOfDoorsLabel.Text = electricCar.NumberOfDoors.ToString();
                            NumberOfSeatsLabel.Text = electricCar.NumberOfSeats.ToString();
                            BatteryCapacityLabel.Text = electricCar.BatteryCapacity.ToString();
                            BatteryCapacityLabel.Visibility = Visibility.Visible;
                            BC.Visibility = Visibility.Visible;
                            IsConvertibleCheckBox.IsChecked = electricCar.IsConvertible;
                            AnnualInsuranceCostLabel.Text = electricCar.getAnnualInsurance().ToString();
                            break;
                        case Truck truck:
                            NumberOfDoors.Content = "Number of Axles";
                            NumberOfSeatsLabel.Text = truck.LoadCapacity.ToString();

                                NumberOfDoorsLabel.Text=truck.NumberOfAxles.ToString();
                            NumberOfSeats.Content = "Load Capacity";
                            BatteryCapacityLabel.Text = "";
                            BatteryCapacityLabel.Visibility = Visibility.Collapsed;
                            BC.Visibility = Visibility.Collapsed;
                            IsConvertibleCheckBox.Visibility = Visibility.Collapsed;
                            AnnualInsuranceCostLabel.Text = truck.getAnnualInsurance().ToString();
                            break;
                    }
                }
                else
                {
                    
                    MakeLabel.Text = "";
                    ModelLabel.Text = "";
                    YearLabel.Text = "";
                    ColorLabel.Text = "";
                    NumberOfDoorsLabel.Text = "";
                    NumberOfSeatsLabel.Text = "";
                    BatteryCapacityLabel.Text = "";
                    IsConvertibleCheckBox.IsChecked = false;
                    AnnualInsuranceCostLabel.Text = "";

                   
                    MessageBox.Show("Vehicle with ID " + vehicleId + " not found.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Vehicle ID", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void VehicleIdTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(VehicleIdTextBox.Text))
            {
                FindButton.IsEnabled = false;
            }
            else
            {
                FindButton.IsEnabled = true;
            }
        }
    }
    }

