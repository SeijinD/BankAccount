using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    class BankAccount
    {
        private string type; //ειδος λογαριασμου
        public string Type { get { return type; } set { type = value; } }
        private double amount; //ποσο κινησης
        public double Amount { get { return amount; } set{ amount = value; } }
        private double balance = 0; //Συνολο χρηματων
        public double Balance { get { return balance; } set { balance = value; } }
        protected const double transactionLimit = 500; //Οριο συνναλαγης
        protected const double interestrate = 0.05; //Ετησιος τοκος
        private DateTime date; //Ημερομηνια
        public DateTime Date { get { return date; } set { date = value; } }

        public void PrintType()
        {
            Console.WriteLine("Type: " + type);
        }

    }
}
