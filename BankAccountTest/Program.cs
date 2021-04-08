using System;
using System.Collections.Generic;

namespace BankAccountTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var account1 = new CurrentAccount("Justin", "Angela", 70000M);
            var account2 = new SavingAccount("Adeboye", "Moses", 45600M);
            var account3 = new SavingAccount("Peter", "Amos", 300860M);
            var account4 = new CurrentAccount("Modupe", "Somade", 12350M);
            var account5 = new SavingAccount("Toria", "Anderson", 30060000M);

            Console.WriteLine($"{account1}\nNew Balance on Withdrawal: {account1.Debit(2500M):C}\n");
            Console.WriteLine($"{account2}\nNew Balance on Deposit: {account2.Credit(4300M):C}\n");
            Console.WriteLine($"{account3}\nNew Balance on Deposit: {account3.Credit(600M):C}\n");
            Console.WriteLine($"{account4}\nNew Balance on Withdrawal: {account4.Debit(5350M):C}\n");
            Console.WriteLine($"{account5}\nNew Balance on Withdrawal: {account5.Debit(10300M):C}\n");

            List<Account> checkAccount = new List<Account>(){account1, account2, account3, account4, account5};

            Console.WriteLine("Representation of new Saving Account owners' Balance after Interest gain add up\n");

            foreach (var acct in checkAccount)
            {
                if(acct is SavingAccount)
                {
                    var newBal = (SavingAccount)acct;
                    var intAddup = newBal.CalculateInterest();
                    Console.WriteLine($"New Saving Account Balance after interest credit accrued: \n{intAddup:C}\n");
                }
            }
        }
    }
}
