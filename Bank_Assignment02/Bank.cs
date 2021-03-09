using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Assignment02
{
    class Bank
    {
        private string bankName;
        private Account[] myBank = new Account[10];

        public string BankName
        {
            get { return this.bankName; }
            set { this.bankName = value; }
        }

        public int SearchAccount (int accountNumber)
        {
            int value = 0;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i].AccountNumber == accountNumber)
                {
                    value = i;
                    break;
                }
            }

            return value;
        }

        public void InsertAccount(Account account)
        {
            bool flag = false;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    myBank[i].GenerateAccountNumber();
                    Console.WriteLine();
                    myBank[i].ShowAccountInformation();
                    Console.WriteLine();
                    flag = true;
                    break;
                }

            }
            if (!flag)
            {
                Console.WriteLine("Sorry Account Couldnt Be Created!");
            }
        }

        public void DeleteAccount(int accountNumber)
        {
            bool flag = false;
            for (int i = 0; myBank[i] != null; i++)
            {
                if (myBank[i].AccountNumber == accountNumber)
                {
                    while (myBank[i+1] != null && i < myBank.Length - 1)
                    {
                        myBank[i] = myBank[i + 1];
                        i++;
                    }
                    myBank[i] = null;
                    Console.WriteLine("Account Deleted Successfully!");
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Sorry Account Couldnt Be Deleted!");
            }
        }
        public void Transaction(int choice, int fromAccountNumber, double amount)
        {
            switch (choice)
            {
                case 1:

                    if(myBank[SearchAccount(fromAccountNumber)].Deposit(amount))
                    {
                        Console.WriteLine("Money Successfully Deposited In Account Number - {0} || Balance - {1}", fromAccountNumber, myBank[SearchAccount(fromAccountNumber)].Balance);
                    }
                    else
                    {
                        Console.WriteLine("Transaction Was Not Successful!");
                    }
                    break;
                case 2:
                    if (myBank[SearchAccount(fromAccountNumber)].Withdraw(amount))
                    {
                        Console.WriteLine("Money Successfully Withdrawn From Account Number - {0} || Balance - {1}", fromAccountNumber, myBank[SearchAccount(fromAccountNumber)].Balance);
                    }
                    else
                    {
                        Console.WriteLine("Transaction Was Not Successful!");
                    }
                    break;
                case 3:

                    Console.WriteLine("Enter Your Receiver Account Number :");
                    int receiverAccountNumber = Convert.ToInt32(Console.ReadLine());
                    int iReceiver = SearchAccount(receiverAccountNumber);
                    if (myBank[SearchAccount(fromAccountNumber)].Transfer(amount, myBank[iReceiver]))
                    {
                        Console.WriteLine("Money Successfully Transfered From Account Number - {0} To Account Number - {1} || Balance - {2}", fromAccountNumber, receiverAccountNumber, myBank[SearchAccount(fromAccountNumber)].Balance);
                    }
                    else
                    {
                        Console.WriteLine("Transaction Was Not Successful!");
                    }
                    break;

                default:
                    Console.WriteLine("Please Input A Valid Choice...");
                    break;
            }
        }

        public void ShowAllTransactions (int accountNumber)
        {
            Console.WriteLine("Account No- {0} || Total Transaction - {1} Current Balance - {2}", accountNumber, myBank[SearchAccount(accountNumber)].Transactions, myBank[SearchAccount(accountNumber)].Balance);
        }

        public void ShowAllAccount ()
        {
            Console.WriteLine("_All Accounts_\n");
            for (int i = 0; myBank[i] != null; i++)
            {
                myBank[i].ShowAccountInformation();
                Console.WriteLine();
            }
        }

    }
}
