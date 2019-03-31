using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    class LotteryAccount : BankAccount
    {
        private const double winpercentage = 0.1; //ποσο νικης

        public LotteryAccount() {}

        public void Withdraw(double amount)
        {
            if (amount < Balance && amount < transactionLimit)
            {
                Random r = new Random();
                double random = r.Next(100);
                if (random > 40 && random < 50)
                {
                    Balance += (amount * 0.4); 
                }

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
            Random r = new Random();
            double random = r.Next(100);
            if (random > 40 && random < 50)
            {
                 amount += (amount * 0.4);
            }

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

        public string AddLottery(string option)
        {
            Date = DateTime.Now;
            string add;
            return add = Date + "  |  " + option + "  |  " + Amount + "  |  " + Balance;
        }

        public void PrintLottery(List<string> listLottery)
        {
            Console.WriteLine("DATE\t\t|  REASON  |  AMOUNT  |  BALANCE  \n -------------------------------------------------");
            foreach (var el in listLottery)
                Console.WriteLine(el);
        }
    }
}
