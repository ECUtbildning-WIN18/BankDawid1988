using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain
{
    class CredicCard
    {
        public int CardNumber { get; set; }
        public int CCV { get; set; }
        public Account _Account { get; set; }
        public Person _Person { get; set; }

        public CredicCard(int cardNumber, int cCV, Account account, Person person)
        {
            CardNumber = cardNumber;
            CCV = cCV;
            _Account = account;
            _Person = person;

        }



        public void Pay(Account konto, decimal belop)
        {




        }
    }
}
