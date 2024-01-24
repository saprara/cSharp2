using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExcercise
{
    public  class CommissionEmployee
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public double GrossSales { get; set; }
        public double CommissionRate { get; set; }
        public CommissionEmployee(int Id, string name,double GrossSales,double CommissionRate){
            this.Id = Id;
            this.Name = name;
            this.GrossSales = GrossSales;
            this.CommissionRate = CommissionRate;
        }
        public double Earnings()
        {
            return GrossSales * CommissionRate;
        }
        public override string ToString()
        {
            return $"Id={Id}" +
                $"\nName={Name}" +
                $"\nGrossSales={GrossSales:C}" +
                $"\nCommissionRate={CommissionRate:p}";

            }
        }
    }

