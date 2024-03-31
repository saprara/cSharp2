using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTYRakshitSapra
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int ManufactureYear { get; set; }
        public string Color { get; set; }


        public Vehicle(int id, string make, string model, int manufactureYear, string color)
        {
            Id = id;
            Make = make;
            Model = model;
            ManufactureYear = manufactureYear;
            Color = color;
        }
        public abstract double getAnnualInsurance();
        public String toString()
        {
            return $"Vehicle  Information:\n" +
                               $"- Id: {Id}\n" +
                               $"- Make: {Make}\n" +
                               $"- Model: {Model}\n" +
                               $"- Year: {ManufactureYear}\n" +
                               $"- Color: {Color}\n";

        }
    }

}
    
