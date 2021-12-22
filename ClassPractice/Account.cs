using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    class Account
    {
        public string Name { get; set; } //auto implemented property
        private decimal balance;

        //constructor sets the Name property to parameter accountName's Value
        public Account(string accountName, decimal initialBalance)//constructor name is class name
        {
            Name = accountName;
            Balance = initialBalance;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }

            private set///can be used only within the class
            {
                //validate that the balance is greater than 0, if not,
                //instance variable balance keeps its prior value
                if (value > 0.0m) //m indicates that 0.0 is a decimal literal
                    balance = value;
            }
        }

        public void Deposit(decimal depositAmmount)
        {
            if (depositAmmount > 0.0m)
            {
                Balance += depositAmmount;
            }
        }
    }
}
