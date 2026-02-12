using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    // ==========================
    // Base Class (Bank)
    // ==========================
    class Bank
    {
        public string bankName = "ABC Bank";

        public void BankInfo()
        {
            Console.WriteLine("Welcome to " + bankName);
        }
    }

    // ==========================
    // Single Inheritance
    // Bank -> Account
    // ==========================
    class Account : Bank
    {
        public string accountHolderName;
        public int accountNumber;
        public double balance;
        public int pin;

        public Account(string name, int accNo, double initialBalance, int userPin)
        {
            accountHolderName = name;
            accountNumber = accNo;
            balance = initialBalance;
            pin = userPin;
        }

        public bool CheckPin(int enteredPin)
        {
            if (enteredPin == pin)
                return true;
            else
                return false;
        }

        public void CheckBalance()
        {
            Console.WriteLine("Available Balance: " + balance);
        }

        public void Deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("Deposit Successful!");
        }
    }

    // ==========================
    // Multilevel Inheritance
    // Bank -> Account -> ATM
    // ==========================
    class ATM : Account
    {
        public ATM(string name, int accNo, double initialBalance, int userPin)
            : base(name, accNo, initialBalance, userPin)
        {
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance = balance - amount;
                Console.WriteLine("Withdrawal Successful!");
            }
            else
            {
                Console.WriteLine("Insufficient Balance!");
            }
        }

        public void ShowDetails()
        {
            Console.WriteLine("\n--- Account Details ---");
            Console.WriteLine("Name: " + accountHolderName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Balance: " + balance);
        }
    }


    // ==========================
    // MAIN METHOD
    // ==========================
    class Program
    {
        static void Main(string[] args)
        {
            // Object Creation (Derived Class Object)
            ATM user = new ATM("Madhan", 123456, 5000, 1234);

            int enteredPin;
            int choice;
            double amount;

            user.BankInfo();

            Console.WriteLine("===== Welcome to ATM =====");
            Console.Write("Enter Your PIN: ");

            string? input = Console.ReadLine();

            // TryParse prevents crash
            if (int.TryParse(input, out enteredPin))
            {
                // PIN Verification
                if (user.CheckPin(enteredPin))
                {
                    Console.WriteLine("Login Successful!");
                }
                else
                {
                    Console.WriteLine("Wrong PIN! Access Denied.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid Input! Please enter numbers only.");
                return;
            }


            // PIN Verification
            if (user.CheckPin(enteredPin))
            {
                // ATM Menu Loop
                do
                {
                    Console.WriteLine("\n1. Check Balance");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Withdraw");
                    Console.WriteLine("4. Account Details");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter Your Choice: ");

                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            user.CheckBalance();
                            break;

                        case 2:
                            Console.Write("Enter Deposit Amount: ");
                            amount = Convert.ToDouble(Console.ReadLine());
                            user.Deposit(amount);
                            break;

                        case 3:
                            Console.Write("Enter Withdraw Amount: ");
                            amount = Convert.ToDouble(Console.ReadLine());
                            user.Withdraw(amount);
                            break;

                        case 4:
                            user.ShowDetails();
                            break;


                        case 5:
                            Console.WriteLine("Thank You! Visit Again.");
                            break;

                        default:
                            Console.WriteLine("Invalid Choice!");
                            break;
                    }

                } while (choice != 5);
            }
            else
            {
                Console.WriteLine("Wrong PIN! Access Denied.");
            }

        }
    }

}
