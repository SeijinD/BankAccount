using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    class SavingsAccount : BankAccount
    {
        public SavingsAccount() {}

        public void Withdraw(double amount)
        {
            if (amount < Balance && amount < transactionLimit)
            {
                Amount = amount;
                Balance -= amount;
                Console.WriteLine("Η αναλυψη πραγματοποιηθηκε.");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Δεν μπορει να πραγματοποιηθη η αναλυψη επειδη δεν φτανει το Balance.");
            }
            else if (amount > transactionLimit)
            {
                Console.WriteLine("Δεν μπορει να πραγματοποιηθη η αναλυψη επειδη ειναι πανω απο το οριο αναλυψης.");
            }
        }

        public void Deposit(double amount)
        {
            Amount = amount;
            Balance += amount;
            Console.WriteLine("Η καταθεση πραγματοποιηθηκε.");
        }

        public void Addinterest()
        {
            Balance -= (interestrate * Balance);
            Amount = (interestrate * Balance);
            Console.WriteLine("Αφερεθηκε ο ετησιος τοκος");
        }

        public string AddSaving(string option)
        {
            Date = DateTime.Now;
            string add;
            return add = Date + "  |  " + option + "  |  " + Amount + "  |  " + Balance;
        }

        public void PrintSaving(List<string> listSaving)
        {
            Console.WriteLine("DATE\t\t|  REASON  |  AMOUNT  |  BALANCE  \n -------------------------------------------------");
            foreach (var el in listSaving)
                Console.WriteLine(el);
        }
    }
}
