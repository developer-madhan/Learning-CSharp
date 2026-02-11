using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    // Base class (OOP Concept)
    class BankAccount
    {
        // Data Members (Variables)
        protected string accountHolderName;
        protected int accountNumber;
        protected double balance;

        // Constructor (DAY-12)
        public BankAccount(string name, int accNo, double initialBalance)
        {
            accountHolderName = name;
            accountNumber = accNo;
            balance = initialBalance;
        }

        // Method to show account details
        public void ShowDetails()
        {
            Console.WriteLine("\n--- Account Details ---");
            Console.WriteLine("Account Holder: " + accountHolderName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Current Balance: " + balance);
        }

        // Virtual method (Polymorphism - DAY-14)
        public virtual void Withdraw(double amount)
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

        // Deposit Method
        public void Deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("Deposit Successful!");
        }

        // Method to check balance
        public void CheckBalance()
        {
            Console.WriteLine("Available Balance: " + balance);
        }
    }

    // Derived class (Inheritance - DAY-13)
    class ATM : BankAccount
    {
        // Constructor calling base constructor
        public ATM(string name, int accNo, double initialBalance)
            : base(name, accNo, initialBalance)
        {
        }

        // Overriding Withdraw method (Polymorphism)
        public override void Withdraw(double amount)
        {
            Console.WriteLine("Processing ATM Withdrawal...");

            if (amount % 100 != 0)
            {
                Console.WriteLine("Enter amount in multiples of 100!");
            }
            else
            {
                base.Withdraw(amount); // Call parent method
            }
        }
    }

    // Main Class
    class Program
    {
        static void Main(string[] args)
        {
            // Creating ATM Object (Object Creation - DAY-08)
            ATM user1 = new ATM("Madhan", 123456, 5000);

            int choice;
            double amount;

            // Loop for ATM Menu (DAY-06)
            do
            {
                Console.WriteLine("\n===== ATM MACHINE =====");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Account Details");
                Console.WriteLine("5. Exit");
                Console.Write("Enter Your Choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                // Switch case (DAY-06)
                switch (choice)
                {
                    case 1:
                        user1.CheckBalance();
                        break;

                    case 2:
                        Console.Write("Enter Deposit Amount: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        user1.Deposit(amount);
                        break;

                    case 3:
                        Console.Write("Enter Withdraw Amount: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        user1.Withdraw(amount);
                        break;

                    case 4:
                        user1.ShowDetails();
                        break;

                    case 5:
                        Console.WriteLine("Thank You! Visit Again.");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            } while (choice != 5); // Continue until user selects Exit
        }
    }

}
