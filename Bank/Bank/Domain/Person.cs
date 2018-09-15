using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumbr { get; set; }

        public Person(string firstName, String lastName, string socialSecurityNumbr)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumbr = socialSecurityNumbr;

        }
    }
}

