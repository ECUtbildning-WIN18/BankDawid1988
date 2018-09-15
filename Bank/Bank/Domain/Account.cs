using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain
{
    class Account
    {
        public int AccuntNumber { set; get; }
        public double Balance { set; get; }



        public Person _person { set; get; }


        public Account(int accountNumber, double balance, Person person)
        {
            AccuntNumber = accountNumber;
            Balance = balance;
            _person = person;



        }
    }
}
