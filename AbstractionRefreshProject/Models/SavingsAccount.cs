using AbstractionBasics.Models;
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// //LD STEP1
/// INHERITING CLASS
/// 
/// we inherit all the behavuiour from "BankAccount.cs" by "SavingsAccount : BankAccount"
/// now we need to add some new members to ADD NEW FUNCTIONALITIES we need -> //LD STEP1
/// </summary>
namespace AbstractionBasics.Models
{
    public class SavingsAccount : BankAccount
    {
        private double interestRate;

        public SavingsAccount(string name, int number, int balance, double rate) : base(name, number) 
        //LD we use the members of the base class
        {
            //LD STEP1
            accountBalance = balance; //LD able to define it because in base class is defined as "private"
            interestRate = rate;
        }

        //LD STEP1
        public double getMonthlyInterest()
        {
            return interestRate * accountBalance;
        }

        //LD here we are optionally overriding a VIRTUAL
        public override int getAccountNumber()
        {
            return base.getAccountNumber() + 5000;
        }
    }
}

