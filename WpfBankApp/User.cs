using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBankApp
{
    internal class User
    {



        public User(string username, string password, string name, string surname, string email, string adress, string iban)

        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.surname = surname;
            this.email = email;

            this.address = address;
            Accounts = new List<BankAccount>();
            Accounts.Add(new BankAccount(iban, "Standart", 0)); // IBANGenerator sınıfını doğru şekilde kullanıldığından emin olun
        }

        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string address { get; set; }

        public List<BankAccount> Accounts { get; set; }


    }
}
