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

        public override bool Withdraw(double amount)
        {
            bool flag = false;
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                transactions++;
                flag = true;
            }
            return flag;
        }

    }
}
