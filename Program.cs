using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string selectAccount = "";
            string option = "";

            BankAccount account = new BankAccount();
            Console.WriteLine("Καλως ηρθες στην Τραπεζα μας!");

            Console.WriteLine("Δωσε τα στοιχεια σου: ");
            Console.WriteLine("Firstname, Lastname, IBAN");
            //Customer newCustomer = new Customer(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            Customer newCustomer = new Customer();

            newCustomer.FirstName = Console.ReadLine();
            newCustomer.LastName = Console.ReadLine();
            try 
	        {	        
		        newCustomer.Iban = int.Parse(Console.ReadLine());
	        }
	        catch (OverflowException ex)
	        {
                Console.WriteLine("Η τιμή ήταν πολύ μεγάλη για ένα Int32.");
                Console.WriteLine("Ξανα δωσε το IBAN: ");
                newCustomer.Iban = int.Parse(Console.ReadLine());
	        }
            
            do //Επιλογη και ελεγχος Account
            {
                Console.WriteLine("Επελεξε τι Account θελεις να φτιαξεις: ");
                Console.WriteLine("1)CreditAccount      2)SavingAccount     3)LotteryAccount");
                selectAccount = Console.ReadLine();
                switch(selectAccount.ToLower())
                {
                    case "creditaccount":
                        account.Type = "CreditAccount";            
                        selectAccount = "quit";
                        break;
                    case "savingaccount":
                        account.Type = "SavingAccount";
                        selectAccount = "quit";
                        break;
                    case "lotteryaccount":
                        account.Type = "LotteryAccount";
                        selectAccount = "quit";
                        break;
                    default: Console.WriteLine("Εδωσες λαθος επιλογη!");
                        break;
                }
            }
            while (selectAccount.ToLower() != "quit");
            
            //Επιλογη κινησης
            if (account.Type == "CreditAccount")
            {
                CreditAccount credit = new CreditAccount();
                List<string> creditList = new List<string>();
                do
                {
                    Console.WriteLine("Επελεξε τι κινηση θελεις να κανεις: ");
                    Console.WriteLine("1)Charge      2)Deposit     3)Addpayment     4)Quit");
                    option = Console.ReadLine();
                    if (option.ToLower() == "charge")
                    {
                        credit.Charge(Convert.ToDouble(Console.ReadLine()));
                    }
                    else if (option.ToLower() == "deposit")
                    {
                        credit.Deposit(Convert.ToDouble(Console.ReadLine()));
                    }
                    else if (option.ToLower() == "addpayment")
                    {
                        credit.Addpayment();
                    }
                    if (option.ToLower() != "quit")
                    {
                        creditList.Add(credit.AddCredit(option));
                    }
                }
                while (option.ToLower() != "quit");
                newCustomer.PrintCustomer(account.Type);
                credit.PrintCredit(creditList);
            }
            else if (account.Type == "SavingAccount")
            {
                SavingsAccount saving = new SavingsAccount();
                List<string> savingList = new List<string>();
                do
                {
                    Console.WriteLine("Επελεξε τι κινηση θελεις να κανεις: ");
                    Console.WriteLine("1)Withdraw      2)Deposit     3)Addinterest     4)Quit");
                    option = Console.ReadLine();
                    if (option.ToLower() == "withdraw")
                    {
                        saving.Withdraw(Convert.ToDouble(Console.ReadLine()));
                    }
                    else if (option.ToLower() == "deposit")
                    {
                        saving.Deposit(Convert.ToDouble(Console.ReadLine()));
                    }
                    else if (option.ToLower() == "addinterest")
                    {
                        saving.Addinterest();
                    }
                    if (option.ToLower() != "quit")
                    {
                        savingList.Add(saving.AddSaving(option));
                    }
                }
                while (option.ToLower() != "quit");
                newCustomer.PrintCustomer(account.Type);
                saving.PrintSaving(savingList);
            }
            else if (account.Type == "LotteryAccount")
            {
                LotteryAccount lottery = new LotteryAccount();
                List<string> lotteryList = new List<string>();
                do
                {
                    Console.WriteLine("Επελεξε τι κινηση θελεις να κανεις: ");
                    Console.WriteLine("1)Withdraw      2)Deposit     3)Addinterest     4)Quit");
                    option = Console.ReadLine();
                    if (option.ToLower() == "withdraw")
                    {
                        lottery.Withdraw(Convert.ToDouble(Console.ReadLine()));
                    }
                    else if (option.ToLower() == "deposit")
                    {
                        lottery.Deposit(Convert.ToDouble(Console.ReadLine()));
                    }
                    else if (option.ToLower() == "addinterest")
                    {
                        lottery.Addinterest();
                    }                   
                    if (option.ToLower() != "quit")
                    {
                        lotteryList.Add(lottery.AddLottery(option));
                    }
                }
                while (option.ToLower() != "quit");
                newCustomer.PrintCustomer(account.Type);
                lottery.PrintLottery(lotteryList);
            }
            

            Console.ReadKey();
        }
    }
}
