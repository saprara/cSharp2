using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace W2IntroToClasses
{
    public class Account
    {
        private double _balance;


        Account() {
            _balance = 0;
        }
        public Account(double balance)
        {
            _balance = balance;
        }
        public double GetBalance()
        {
            return _balance;
        }
        public void SetBalance(double balance)
        {
            
                _balance = balance;
            
                

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
