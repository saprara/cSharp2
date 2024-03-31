using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1RakshitSapra
{
    public class Truck : Vehicle
    {
        public int NumberOfAxles { get; set; }
        public double LoadCapacity { get; set; }

       public  Truck(int id, string make, string model, int manufactureYear, 
           string color,int numberOfAxles, double loadCapacity) 
            :base(id, make, model, manufactureYear, color)
        {
            NumberOfAxles = numberOfAxles;
            LoadCapacity = loadCapacity;
        }
        public override double getAnnualInsurance()
        {
            double monthlyInsurance = 0;
            ////////////////////////////
            if (ManufactureYear >= 2010)
                monthlyInsurance += 200;
            else if (ManufactureYear >= 2000 && ManufactureYear <= 2009)
                monthlyInsurance += 400;
            else if (ManufactureYear >= 1990 && ManufactureYear <= 1999)
                monthlyInsurance += 800;
            else
                monthlyInsurance += 1000;
            ///////////////////////////////
            
            if (NumberOfAxles == 2)
                monthlyInsurance += 50;
            else if (NumberOfAxles == 4)
                monthlyInsurance += 100;
            else if (NumberOfAxles >= 5)
                monthlyInsurance += 150;
            //////////////////////////////
           
            if (LoadCapacity <= 1000)
                monthlyInsurance += 50;
            else if (LoadCapacity >= 1001 &&LoadCapacity <= 2000)
                monthlyInsurance += 100;
            else if (LoadCapacity >= 2001 && LoadCapacity <= 3000)
                monthlyInsurance += 150;
            else
                monthlyInsurance += 200;

            return monthlyInsurance * 12;
        }
        public override string ToString()
        {
            return base.ToString() + $"- Number of Axles: {NumberOfAxles}\n" +
                   $"- Load Capacity: {LoadCapacity} lbs\n" +
                   $"- Annual Insurance Cost: {getAnnualInsurance().ToString("C2")}"; ;
        }
    }
}
