using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2IntroToClasses
{
    public class Product
    {
        private int id;
        private string _name;
        private double _price;
        public Product()
        {
            id = 0;
            _name = "";
            _price = 0;
        }
        public Product(int id, string name, double price)
        {
            this.id = id;
            this._name = name;
            this._price = price;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }

        }
    }
}
