using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Assignment02 
{
    class Savings_Account : Account
    {
        
        public override void ShowAccountInformation()
        {
            base.ShowAccountInformation();
        }

        public override bool Withdraw(double amount)
        {
            bool flag = false;
            if (amount > 0 && amount <= balance && (balance - amount > 0))
            {
                balance -= amount;
                transactions++;
                flag = true;
            }
            return flag;
            
        }

        public override bool Transfer(double amount, Account receiver)
        {
            bool flag = false;
            if (amount > 0 && amount <= balance && (balance - amount > 0))
            {
                balance -= amount;
                receiver.Deposit(amount);
                transactions++;
                flag = true;
            }
            return flag;
        }

    }
}
