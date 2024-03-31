using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTYRakshitSapra
{
    public class ElectricCar : Car
    {

        public double BatteryCapacity { get; set; }

        public ElectricCar(int id, string make, string model, int manufactureYear, string color,
            int numberOfDoors, int numberOfSeats, Boolean isConvertible, double batteryCapacity)
            : base(id, make, model, manufactureYear, color, numberOfDoors, numberOfSeats, isConvertible)
        {
            BatteryCapacity = batteryCapacity;
        }

        

        public override double getAnnualInsurance()
        {
            double monthlyInsurance = 0;

            if (ManufactureYear >= 2010)
                monthlyInsurance += 100;
            else if (ManufactureYear >= 2000 && ManufactureYear <= 2009)
                monthlyInsurance += 200;
            else if (ManufactureYear >= 1990 && ManufactureYear <= 1999)
                monthlyInsurance += 300;
            else
                monthlyInsurance += 400;

            /////////////////////////////

            if (NumberOfDoors == 2)
                monthlyInsurance += 50;
            else if (NumberOfDoors == 4)
                monthlyInsurance += 100;
            else if (NumberOfDoors >= 5)
                monthlyInsurance += 150;
            /////////////////////////////

            if (NumberOfSeats == 2)
                monthlyInsurance += 50;
            else if (NumberOfSeats == 4)
                monthlyInsurance += 100;
            else if (NumberOfSeats >= 5)
                monthlyInsurance += 150;

            //////////////////////////////
            if (IsConvertible)
                monthlyInsurance += 100;
            /////////////////////////
            if (BatteryCapacity <= 50)
                monthlyInsurance += 50;
            else if (BatteryCapacity <= 75)
                monthlyInsurance += 100;
            else if (BatteryCapacity <= 100)
                monthlyInsurance += 150;
            else
                monthlyInsurance += 200;
            ///////////////////////////////////
            return monthlyInsurance * 12;
        }
        public override string ToString()
        {
            return base.ToString() + $"- Battery Capacity: {BatteryCapacity} kWh\n" +
                   $"- Annual Insurance Cost: {getAnnualInsurance().ToString("C2")}"; ;
        }
    }
}

