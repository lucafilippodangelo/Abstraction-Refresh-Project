using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// //LD STEP0
/// BASE CLASS
/// 
/// This class define characteristics common to any type of bank account, 
/// such as account holder name, account number and current balance. Imagine, however, 
/// that our banking program needs to support a number of specific types of account. 
/// For example, the bank might offer its customers an interest bearing savings account. 
/// A savings account will have all the characteristics of our BankAccount class but would also 
/// need a way to store the prevailing interest rate. One option would be to create a brand new 
/// class from the ground up called SavingsAccount which duplicates everything we have in our 
/// BankAccount class, plus extra members needed for a savings account. Another, 
/// more efficient method is to derive a SavingsAccount class from the BankAccount class 
/// and then add in the extra functionality into this subclass.
/// </summary>
namespace AbstractionBasics.Models
{
    public class BankAccount
    {

        private string accountName; //LD just this classe can see it
        protected int accountBalance; //LD just child classes can see it
        private int accountNumber;

        public BankAccount(string name, int number)
        {
            accountName = name;
            accountNumber = number;
        }

        //LD this method can be overrided
        public virtual int getAccountNumber()
        {
            return accountNumber;
        }

        public void setAccountNumber(int newNumber)
        {
            accountNumber = newNumber;
        }

    }
}
