using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.TransactionModel
{

    class Transactions
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Note { get; }

        public Transactions (decimal amount, DateTime date, string Notes)
        {
            this.Amount = amount;
            this.Date = date;
            this.Note = Notes;
        }
    }

}
