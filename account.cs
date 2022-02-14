using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class account
    {
        public string Name{ get; set; }
        public decimal balance;

        public account(string accountName, decimal initialBalance)
        {
            Name = accountName;
            Balance = initialBalance;
        }

        private decimal Balance
        {
            get
            {
                return Balance;

            }

            set
            {
                if(value  >= 0.0m)
                {
                    Balance = value;
                }
            }
        }
        public void Deposit(decimal depositAmount)
        {
            if (depositAmount > balance)
            {
                Balance = Balance + depositAmount;

            }
        }
    }
}
