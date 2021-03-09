using System;

namespace Bank_Assignment02
{
    abstract class Account
    {
        protected string dateOfBirth;
        private int accountNumber;
        protected string accountName;
        protected double balance;
        protected string accountType;
        private static int accountGenerateNumber = 3300;
        protected int transactions = 0;
        protected string address;



        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }
        public int Transactions
        {
            get { return this.transactions; }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public string DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }

        public void GenerateAccountNumber()
        {
            this.accountNumber = accountGenerateNumber;
            accountGenerateNumber++;
        }


        public int AccountNumber
        {
            get { return this.accountNumber; }
        }
         
        abstract public bool Withdraw(double amount);

         public bool Deposit(double amount)
        {
            bool flag = false;
            if (amount > 0)
            {
                balance += amount;
                transactions++;
                flag = true;
            }
            return flag;
        }

        abstract public bool Transfer(double amount, Account receiver);

        virtual public void ShowAccountInformation()
        {
            Console.WriteLine("__Account Information__\nAccount Type - {0}\nAccount Name - {1}\nAccount Number - {2}\nBalance - {3}\nAddress - {4}\nDate Of Birth - {5}"
                ,this.accountType, this.accountName, this.accountNumber, this.balance, this.address, this.dateOfBirth);
            Console.WriteLine();
        }


    }
}
