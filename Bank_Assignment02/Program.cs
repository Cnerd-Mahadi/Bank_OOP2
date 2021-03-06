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
            Console.WriteLine("________________________WELCOME TO {0} BANK________________________________\n", b1.BankName);
            bool value = true;
            while (value)
            {
                Console.WriteLine("Please Enter The Service You Want_\n");
                Console.WriteLine("\t1.Add Account\n\t2.Delete Account\n\t3.Transaction\n\t4.Show All Accounts\n\t5.Quit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Account a1 = new Account();
                        Console.WriteLine("Enter Your Account Information To Create Account...");
                        Console.WriteLine("Account Name :");
                        a1.AccountName = Console.ReadLine();
                        Console.WriteLine("Balance :");
                        a1.Balance = Convert.ToInt32(Console.ReadLine());
                        b1.AddAccount(a1);
                        break;

                    case 2:
                        Console.WriteLine("Enter Account Number To Delete :");
                        int deleteAccountNumber = Convert.ToInt32(Console.ReadLine());
                        b1.DeleteAccount(deleteAccountNumber);
                        break;

                    case 3:
                        Console.WriteLine("Enter The Transaction Service:\n\t1.Deposit\n\t2.Withdraw\n\t3.Transfer");
                        int c2 = Convert.ToInt32(Console.ReadLine());
                        if (c2 == 1 || c2 == 2 || c2 == 3)
                        {
                            Console.WriteLine("Enter The Amount:");
                            double amount = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter The Account Number:");
                            int senderAccountNumber = Convert.ToInt32(Console.ReadLine());
                            b1.Transaction(c2, senderAccountNumber, amount);
                        }
                        else
                        {
                            Console.WriteLine("Please Input A Valid Choice...");
                        }
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
