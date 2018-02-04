using System;
using System.Collections.Generic;
using System.Text;

//LD STEP3
namespace AbstractionBasics.Models
{
    public abstract class AbstractBankAccount
    {

        protected string _commonSentence; 

        //LD ABSTRACT MEMBER 
        //abstract member is not implemented in the base class and must be implemented 
        //in derived classes.
        public abstract void printAccountSentence();

        //LD VIRTUAL MEMBER
        //A member defined as virtual must be implemented in the base class, but may be optionally 
        //overriden in the derived class if different behavior is required.
        public virtual string getAccountSentence()
        {
            string newSentence = _commonSentence + " printed by BASE CLASS";
            Console.WriteLine(newSentence);
            return newSentence;
        }

    }
}