using System;
using System.Collections.Generic;
using ConsoleTables;
using System.Linq;

namespace A1RakshitSapra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Car(1, "Toyota", "Corolla", 2015, "Black", 4, 5, false));
            vehicles.Add(new Truck(2, "Ford", "Truck", 2018, "White", 4, 10000));
            vehicles.Add(new ElectricCar(3, "Tesla", "Model S", 2020, "White", 4, 5, false, 75.0));

            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Display all vehicles");
            Console.WriteLine("2. Get a vehicle by ID");
            Console.WriteLine("3. Sort vehicles by insurance cost");
            Console.WriteLine("4. Exit");

            while (true)
            {
                Console.Write("Enter your choice (1-4): ");
                bool exit = false;
                int choice;
                string input = Console.ReadLine();

                if (int.TryParse(input, out choice))
                {
                    if (choice == 1)
                    {
                        var carTable = new ConsoleTable("Id", "Make", "Model", "Year", "Color", "Number of Doors", "Number of Seats", "Is Convertible");
                        var truckTable = new ConsoleTable("Id", "Make", "Model", "Year", "Color", "Number of Axles", "Load Capacity (lbs)");
                        var electricCarTable = new ConsoleTable("Id", "Make", "Model", "Year", "Color", "Number of Doors", "Number of Seats", "Is Convertible", "Battery Capacity (kWh)");

                        foreach (var vehicle in vehicles)
                        {
                            if (vehicle is Car car && !(vehicle is ElectricCar))
                            {
                                string isConvertible = car.IsConvertible ? "Yes" : "No"; 
                                carTable.AddRow(car.Id, car.Make, car.Model, car.ManufactureYear, car.Color, car.NumberOfDoors, car.NumberOfSeats, isConvertible);
                            }
                            else if (vehicle is Truck truck)
                            {
                                truckTable.AddRow(truck.Id, truck.Make, truck.Model, truck.ManufactureYear, truck.Color, truck.NumberOfAxles, truck.LoadCapacity);
                            }
                            else if (vehicle is ElectricCar electricCar)
                            {
                                string isConvertible = electricCar.IsConvertible ? "Yes" : "No"; 
                                electricCarTable.AddRow(electricCar.Id, electricCar.Make, electricCar.Model, electricCar.ManufactureYear, electricCar.Color, electricCar.NumberOfDoors, electricCar.NumberOfSeats, isConvertible, electricCar.BatteryCapacity + " kWh");
                            }
                        }

                        Console.WriteLine("Cars:");
                        Console.WriteLine(carTable.ToString());
                        Console.WriteLine("Trucks:");
                        Console.WriteLine(truckTable.ToString());
                        Console.WriteLine("Electric Cars:");
                        Console.WriteLine(electricCarTable.ToString());
                    }
                    else if (choice == 2)
                    {
                        var table = new ConsoleTable("ID", "Make", "Model", "Year");
                        vehicles.ForEach(vehicle => table.AddRow(vehicle.Id, vehicle.Make, vehicle.Model, vehicle.ManufactureYear));
                        Console.WriteLine(table.ToString());

                        Console.Write("Enter vehicle ID: ");
                        int id;
                        string input2 = Console.ReadLine();

                        if (int.TryParse(input2, out id))
                        {
                            var query = vehicles.FirstOrDefault(vehicle => vehicle.Id == id);

                            if (query != null)
                            {
                                var vehicleTable = new ConsoleTable("Attribute", "Value");

                                vehicleTable.AddRow("Type", query.GetType().Name);
                                vehicleTable.AddRow("ID", query.Id);
                                vehicleTable.AddRow("Make", query.Make);
                                vehicleTable.AddRow("Model", query.Model);
                                vehicleTable.AddRow("Year", query.ManufactureYear);
                                vehicleTable.AddRow("Color", query.Color);

                                double insuranceCost = query.getAnnualInsurance();
                                vehicleTable.AddRow("Insurance Cost", insuranceCost.ToString("C"));

                                if (query is Car car)
                                {
                                    string isConvertible = car.IsConvertible ? "Yes" : "No"; 
                                    vehicleTable.AddRow("Number of Doors", car.NumberOfDoors);
                                    vehicleTable.AddRow("Number of Seats", car.NumberOfSeats);
                                    vehicleTable.AddRow("Is Convertible", isConvertible);
                                }
                                else if (query is Truck truck)
                                {
                                    vehicleTable.AddRow("Number of Axles", truck.NumberOfAxles);
                                    vehicleTable.AddRow("Load Capacity (lbs)", truck.LoadCapacity);
                                }
                                else if (query is ElectricCar electricCar)
                                {
                                    string isConvertible = electricCar.IsConvertible ? "Yes" : "No"; 
                                    vehicleTable.AddRow("Number of Doors", electricCar.NumberOfDoors);
                                    vehicleTable.AddRow("Number of Seats", electricCar.NumberOfSeats);
                                    vehicleTable.AddRow("Is Convertible", isConvertible);
                                    vehicleTable.AddRow("Battery Capacity (kWh)", electricCar.BatteryCapacity);
                                }

                                Console.WriteLine(vehicleTable.ToString());
                            }
                            else
                            {
                                Console.WriteLine("No vehicle found with that ID.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                    }
                    else if (choice == 3)
                    {
                        var sortedVehicles = vehicles.OrderBy(vehicle => vehicle.getAnnualInsurance());
                        var table = new ConsoleTable("Id", "Make", "Model", "Annual Insurance Cost");

                        foreach (var vehicle in sortedVehicles)
                        {
                            double insuranceCost = vehicle.getAnnualInsurance();
                            table.AddRow(vehicle.Id, vehicle.Make, vehicle.Model, insuranceCost.ToString("C"));
                        }

                        Console.WriteLine(table.ToString());
                    }
                    else if (choice == 4)
                    {
                        exit = true;
                        Console.WriteLine("Exiting program...");
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}
