using AbstractionBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstractionBasics
{
    class Program
    {
        //LD test
        static void Main(string[] args)
        {
            //LD comment one of those at time
            //CreateSavingsAccount();

            PlayWithAbstractBankAccount();

            Console.ReadLine();
        }

        public static void CreateSavingsAccount()
        {
            var x = new SavingsAccount("luca bank account", 1, 100, 20);

            Console.WriteLine("Account Number: " + x.getAccountNumber());
            Console.WriteLine("Montly Interest: " + x.getMonthlyInterest());
        }

        public static void PlayWithAbstractBankAccount()
        {
            //LD STEP6 
            //LD declare a list with items of type BASE CLASS
            List<AbstractBankAccount> aList = new List<AbstractBankAccount>();

            //LD add subclasses items to the list
            aList.Add(new SavingsAccountFromAbstractBankAccount());
            aList.Add(new DebitAccountFromAbstractBankAccount());

            //LD call a method in both classes that must be overrided

            // for the item "SavingsAccountFromAbstractBankAccount" I will call the overrided "getAccountSentence()" once implemented
            // and from inside this method, the base method "base.getAccountSentence()".

            // for the item "DebitAccountFromAbstractBankAccount" I will call the virtual "getAccountSentence()"
            // from the base class, once is not implemented.
            foreach (AbstractBankAccount anItem in aList)
            {
                anItem.printAccountSentence();
                anItem.getAccountSentence();
            }


        }
    }
}
