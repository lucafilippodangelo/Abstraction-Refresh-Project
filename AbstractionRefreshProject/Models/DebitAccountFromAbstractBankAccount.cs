using System;
using System.Collections.Generic;
using System.Text;

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
