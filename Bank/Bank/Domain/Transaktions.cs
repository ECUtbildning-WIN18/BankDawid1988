using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain
{
    class Transaktions
    {

        public DateTime Date { get; set; }
        public double Sum { get; set; }
        public int ReceiverAccount { get; set; }
        public Account Account { get; set; }

        public Transaktions(DateTime date, double sum,
            int receiverAccount, Account account)
        {
            Date = date;
            Sum = sum;
            ReceiverAccount = receiverAccount;
            Account = account;

        }

        
    }
}
