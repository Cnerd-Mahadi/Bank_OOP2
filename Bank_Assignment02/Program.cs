using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank b1 = new Bank();
            b1.BankName = "STAY HUMBLE";
            Console.WriteLine("\n\t\t\t\t\t|| WELCOME TO {0} BANK ||\t\t\n", b1.BankName);
            bool value = true;
            while (value)
            {
                Console.WriteLine("Please Enter The Service You Want_\n");
                Console.WriteLine("\t1.Open Account\n\t2.Delete Account\n\t3.Transaction\n\t4.Show All Accounts\n\t5.Quit\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nWhat Kind Of Account Do You Want To Open?\n\t1.Savings\n\t2.Checking\n\t3.Back\n");
                        int ac = Convert.ToInt32(Console.ReadLine());
                        if(ac == 1)
                        {
                            Account a1 = new Savings_Account();
                            Console.WriteLine("\nEnter Your Account Information To Create Account...");
                            Console.WriteLine("Account Holder Name :");
                            a1.AccountName = Console.ReadLine();
                            a1.AccountType = "Savings Account";
                            Console.WriteLine("Balance :");
                            a1.Balance = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Address - House No, Road No, City, Country");
                            a1.Address = Console.ReadLine();
                            Console.WriteLine("Date Of Birth :");
                            a1.DateOfBirth = Console.ReadLine();
                            b1.InsertAccount(a1);
                        }
                        else if (ac == 2)
                        {
                            Account a1 = new Checking_Account();
                            Console.WriteLine("\nEnter Your Account Information To Create Account...");
                            Console.WriteLine("Account Holder Name :");
                            a1.AccountName = Console.ReadLine();
                            a1.AccountType = "Checking Account";
                            Console.WriteLine("Balance :");
                            a1.Balance = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Address - House No, Road No, City, Country");
                            a1.Address = Console.ReadLine();
                            Console.WriteLine("Date Of Birth :");
                            a1.DateOfBirth = Console.ReadLine();
                            b1.InsertAccount(a1);
                        }
                        else
                        {
                            break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("\nEnter Account Number To Delete :");
                        int deleteAccountNumber = Convert.ToInt32(Console.ReadLine());
                        b1.DeleteAccount(deleteAccountNumber);
                        break;

                    case 3:
                        Console.WriteLine("\nEnter The Transaction Service:\n\t1.Deposit\n\t2.Withdraw\n\t3.Transfer\n\t4.Show All Transaction\n\t5.Back");
                        int c2 = Convert.ToInt32(Console.ReadLine());
                        if (c2 == 1 || c2 == 2 || c2 == 3 )
                        {
                            Console.WriteLine("Enter The Amount:");
                            double amount = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter The Account Number:");
                            int senderAccountNumber = Convert.ToInt32(Console.ReadLine());
                            b1.Transaction(c2, senderAccountNumber, amount);
                        }

                        else if (c2 == 4)
                        {
                            Console.WriteLine("Enter Account Number To See All Transactions Of That Account :");
                            int accountNumber = Convert.ToInt32(Console.ReadLine());
                            b1.ShowAllTransactions(accountNumber);
                        }

                        else if (c2 == 5)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please Input A Valid Choice...");
                        }
                        break;

                    case 4:
                        Console.WriteLine();
                        b1.ShowAllAccount();
                        break;
              
                    case 5:
                        value = false;
                        Console.WriteLine("\n___________Thank You For Chosing Our Service!______________");
                        break;
                    default:
                        Console.WriteLine("Please Input A Valid Choice...");
                        break;
                }
            }
        }

    }
    }
