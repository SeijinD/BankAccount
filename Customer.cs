using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Customer
    {
        private string firstName;
        public string FirstName { get { return firstName; } set { firstName = value; } }
        private string lastName;
        public string LastName { get { return lastName; } set { lastName = value; } }
        private int iban;
        public int Iban { get { return iban; } set { iban = value; } }

        public Customer() {}

        public Customer(string firstName, string lastName, string iban)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.iban = int.Parse(s: iban);
        }

        public void PrintCustomer(string type)
        {
            Console.WriteLine("IBAN: " + iban);
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.WriteLine("Type: " + type);
        }

    }
}
