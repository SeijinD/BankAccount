using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CreditAccount : BankAccount
    {
        private const double fee = 0.8; //Αμοιβη

        public CreditAccount() {}

        public void Charge(double amount)
        {
            if (amount < Balance && amount < transactionLimit)
            {
                Amount = amount;
                Balance -= (amount * fee);
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

        public void Addpayment()
        {
            Balance -= (interestrate * Balance);
            Amount = (interestrate * Balance);
            Console.WriteLine("Αφερεθηκε ο ετησιος τοκος");
        }

        public string AddCredit(string option)
        {
            Date = DateTime.Now;
            string add;
            return add = Date + "  |  " + option + "  |  " + Amount + "  |  " + Balance;
        }

        public void PrintCredit(List<string> listCredit)
        {
            Console.WriteLine("DATE\t\t\t|  REASON  |  AMOUNT  |  BALANCE  \n -------------------------------------------------");
            foreach (var el in listCredit)
                Console.WriteLine(el);
        }
    }
}
