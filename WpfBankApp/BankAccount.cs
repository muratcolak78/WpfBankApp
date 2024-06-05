using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBankApp
{
    public class BankAccount
    {
        public string IBAN { get; set; }
        public string AccountName { get; set; }
        public double Balance { get; set; }



        public BankAccount(string iBAN, string accountName, double balance)
        {
            IBAN = iBAN;
            AccountName = accountName;
            Balance = balance;

        }


        // Geld einzahlen
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        // Geld abheben
        public bool Withdraw(double amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
