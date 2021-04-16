using System;
using System.Collections.Generic;
using System.Text;
using BankApp.TransactionModel;
namespace BankApp.AccountModel
{

    public class Accounts
    {
        public string Number { get; }
        public string OwnerName { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var element in EveryTransaction)
                {
                    balance += element.Amount;
                }
                return balance;
            }
        }

        static Random rand = new Random();
        private int AccountNumber = rand.Next(566560, 7897800);
        private List<Transactions> EveryTransaction = new List<Transactions>();

        public Accounts(string Name, decimal InitialBalance)
        {
            this.OwnerName = Name;
            DepositMoney(InitialBalance, DateTime.Now, "initial deposit");
            this.Number = "013" + AccountNumber.ToString();
        }

        public void DepositMoney(decimal Amount, DateTime date, string Note)
        {
            if (Amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Amount), "Amount of Deposit must be gtreater than zero");
            }
            var Deposit = new Transactions(Amount, date, Note);
            EveryTransaction.Add(Deposit);
        }

        public void WithdrawMoney(decimal Amount, DateTime date, string Note)
        {
            if (Amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Amount), "Amount of Withdrawal must be greater than zero");
            }
            if (Balance - Amount <= 1000)
            {
                throw new InvalidOperationException("Not Sufficient Funds for this Withdrawal.");
            }
            var Withdrawal = new Transactions(-Amount, date, Note);
            EveryTransaction.Add(Withdrawal);
        }

        public string AccountStatement()
        {
            var Statement = new StringBuilder();
            Statement.AppendLine("Date\t\tAmount\tNote");
            foreach (var el in EveryTransaction)
            {
                Statement.AppendLine($"{el.Date.ToShortDateString()}\t{el.Amount}\t{el.Note}");
            }
            return Statement.ToString();
        }
    }
}