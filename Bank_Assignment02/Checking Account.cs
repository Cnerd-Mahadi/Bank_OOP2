using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Assignment02 
{
    class Checking_Account : Account
    {

        public override void ShowAccountInformation()
        {
            base.ShowAccountInformation();
        }

        public override void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                TransactionIncrement();
            }
        }

    }
}
