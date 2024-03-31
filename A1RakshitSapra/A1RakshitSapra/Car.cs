using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1RakshitSapra
{
    public class Car : Vehicle
    {
       
        public int NumberOfDoors { get; set; }
        public int NumberOfSeats  { get; set; }
        public Boolean IsConvertible { get; set; }
        public Car(int id, string make, string model, int manufactureYear, string color,
            int numberOfDoors, int numberOfSeats, Boolean isConvertible) 
            : base(id, make, model, manufactureYear, color)
        {
            NumberOfDoors = numberOfDoors;
            NumberOfSeats = numberOfSeats;
            IsConvertible = isConvertible;
        }

        public override double getAnnualInsurance()
        {
          
            double monthlyInsurance = 0;
            ///////////////////////////
            if (ManufactureYear >= 2010)
                monthlyInsurance += 100;
            else if (ManufactureYear >= 2000 && ManufactureYear <= 2009)
                monthlyInsurance += 200;
            else if (ManufactureYear >= 1990 && ManufactureYear <= 1999)
                monthlyInsurance += 300;
            else
                monthlyInsurance += 400;
            ///////////////////////////
            if (NumberOfDoors == 2)
                monthlyInsurance += 50;
            else if (NumberOfDoors == 4)
                monthlyInsurance += 100;
            else if (NumberOfDoors >= 5)
                monthlyInsurance += 150;
            ///////////////////////////
            if (NumberOfSeats == 2)
                monthlyInsurance += 50;
            else if (NumberOfSeats == 4)
                monthlyInsurance += 100;
            else if (NumberOfSeats >= 5)
                monthlyInsurance += 150;
            ///////////////////////////
            if (IsConvertible)
                monthlyInsurance += 100;
            ///////////////////////////
            return monthlyInsurance*12;

            
        }
        public override string ToString()
        {
            return base.ToString()+
                           $"- Number of Doors: {NumberOfDoors}\n" +
                           $"- Number of Seat: {NumberOfSeats} lbs\n" +
                           $"- Annual Insurance Cost: {getAnnualInsurance().ToString("C2")}"; ;
        }

    }
}
