using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class BankAccount
    {
        public string Name { get; set; }

        //globally unique identifier
        public Guid AccountNumber { get; set; }

        public decimal Balance { get; set; }

        //Konstruktor w klasie do której się odnosi, najczęściej publiczny
        public BankAccount( string name) 
        {
            Name = name;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }

    }
}
