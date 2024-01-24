using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2IntroToClasses
{
    public class AccountWithProperties
    {
        private double _balance;

        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value >= 0)
                    _balance = value;
            }
        }

        AccountWithProperties()
        {
            _balance = 0;
        }
        public AccountWithProperties(double balance)
        {
            Balance = _balance;
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
            else
                throw new Exception("Amount cannot be less than zero");


        }
        public void withdraw(double amount)
        {
            if (amount <= _balance)
            {
                _balance -= amount;
            }
            else
                throw new Exception("Amount cannot be more than the balamce");

        }
    }
}
    
