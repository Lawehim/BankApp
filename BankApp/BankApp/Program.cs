using BankApp.AccountModel;
using BankApp.TransactionModel;
using System;
using System.Collections.Generic;

namespace BankApp
{
    public class Customer
    {
        //private string FirstName { get; set; }
        //private string LastName { get; set; }
        //private string FullName { get; set; }
        //private string CustomerId { get; set; }
        //private int BVNnumber { get; set; }
        //public string ResidentialAddress { get; set; }
        //public string EmailAddress { get; set; }
        //private Dictionary<string, string> UserName = new Dictionary<string, string>();

        
        static void Main(string[] args)
        {
            var myAccount = new Accounts("Lawrence", 50000);
            Console.WriteLine($"Account {myAccount.Number} was created for {myAccount.OwnerName} with {myAccount.Balance} initial deposit\n");

            myAccount.WithdrawMoney(15000, DateTime.Now, "Akin Jafa");
            Console.WriteLine($"Your Account balance is: {myAccount.Balance}\n");
            Console.WriteLine(myAccount.AccountStatement());
        }

    }
}
