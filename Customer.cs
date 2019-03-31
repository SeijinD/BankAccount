using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    class Customer
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        private int iban { get; set; }

        public Customer(string firstName, string lastName, string iban)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.iban = int.Parse(s: iban);
        }

        public void PrintCustomer()
        {
            Console.WriteLine("IBAN: " + iban);
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

    }
}
