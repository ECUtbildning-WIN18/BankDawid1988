using System;
using Bank.Domain;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Person kund_Dawid = new Person("Dawid ", "Owizyc ", "880405-1001 ");
            Account konto1 = new Account(101, 50.05, kund_Dawid);
            CredicCard Dawidkreditkort = new CredicCard(123456789, 321, konto1, kund_Dawid);




            Person kund_Kamilla = new Person("Kamilla ", "Lindblad ", "871228-1002 ");
            Account konto2 = new Account(102, 50, kund_Kamilla);
            CredicCard Kamilakreditkort = new CredicCard(321654987, 147, konto2, kund_Kamilla);




            Console.WriteLine("{0}{1}{2}", kund_Dawid.FirstName, kund_Dawid.LastName, kund_Dawid.SocialSecurityNumbr);
            Console.WriteLine("AccountNr: {0} Balance: {1} kr", konto1.AccuntNumber, konto1.Balance);
            Console.WriteLine("CardNr: {0} CCV: {1} ", Dawidkreditkort.CardNumber, Dawidkreditkort.CCV, Dawidkreditkort._Account, Dawidkreditkort._Person);


            Console.WriteLine("\n\n");










            Console.WriteLine("{0}{1}{2}", kund_Kamilla.FirstName, kund_Kamilla.LastName, kund_Kamilla.SocialSecurityNumbr);

            Console.WriteLine("AccountNr: {0} Balance: {1} kr", konto2.AccuntNumber, konto2.Balance);

            Console.WriteLine("CardNr: {0} CCV: {1} ", Kamilakreditkort.CardNumber, Kamilakreditkort.CCV, Kamilakreditkort._Account, Kamilakreditkort._Person);



            Console.ReadKey();






        }
    }
}
