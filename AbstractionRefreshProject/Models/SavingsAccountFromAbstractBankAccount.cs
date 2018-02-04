using System;
using System.Collections.Generic;
using System.Text;

//LD STEP4
namespace AbstractionBasics.Models
{
    class SavingsAccountFromAbstractBankAccount : AbstractBankAccount
    {
        public override void printAccountSentence()
        {
            _commonSentence = "SAVINGS ACCOUNT";
            Console.WriteLine(_commonSentence);
        }

        public override string getAccountSentence()
        {
            //LD note the use of ".base"
            var someText = base.getAccountSentence() + " - OVERRIDED and printed by " + _commonSentence;
            Console.WriteLine(someText);
            return "";
        }
    }
}
