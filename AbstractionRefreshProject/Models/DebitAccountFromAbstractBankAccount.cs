using System;
using System.Collections.Generic;
using System.Text;

//LD STEP5
namespace AbstractionBasics.Models
{
    class DebitAccountFromAbstractBankAccount : AbstractBankAccount
    {
        public override void printAccountSentence()
        {
            _commonSentence = "DEBIT ACCOUNT";
            Console.WriteLine(_commonSentence);
        }

    }
}
