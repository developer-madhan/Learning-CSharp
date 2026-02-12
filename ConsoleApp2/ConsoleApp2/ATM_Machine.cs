using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    // Base class (OOP Concept)


    class ATM
    {
        // Variables (Data Members)
        string accountHolderName;
        int accountNumber;
        double balance;
        int pin;   // Simple password

        // Constructor
        public ATM(string name, int accNo, double initialBalance, int userPin)
        {
            accountHolderName = name;
            accountNumber = accNo;
            balance = initialBalance;
            pin = userPin;
        }

        // Method to check PIN
        public bool CheckPin(int enteredPin)
        {
            if (enteredPin == pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Method to check balance
        public void CheckBalance()
        {
            Console.WriteLine("Available Balance: " + balance);
        }

        // Deposit Method
        public void Deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("Deposit Successful!");
        }

        // Withdraw Method
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

        // Show Account Details
        public void ShowDetails()
        {
            Console.WriteLine("\n--- Account Details ---");
            Console.WriteLine("Name: " + accountHolderName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Balance: " + balance);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create Object
            ATM user = new ATM("Madhan", 123456, 5000, 1234);

            int enteredPin;
            int choice;
            double amount;

            Console.WriteLine("===== Welcome to ATM =====");
            Console.Write("Enter Your PIN: ");
            enteredPin = Convert.ToInt32(Console.ReadLine());

            // Password Check
            if (user.CheckPin(enteredPin))
            {
                Console.WriteLine("Login Successful!");

                // ATM Menu using do-while loop
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
