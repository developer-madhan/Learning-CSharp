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
   /* class atmProgram
    {
        static void Main(string[] args)
        {
            ATM user = new ATM("Madhan", 123456, 5000, 1234);

            int enteredPin = 0;
            int attempts = 0;
            bool loginSuccess = false;

            user.BankInfo();
            Console.WriteLine("===== Welcome to ATM =====");

            //  PIN Attempt Loop (Max 3)
            while (attempts < 3)
            {
                Console.Write("Enter Your PIN: ");
                string? input = Console.ReadLine();

                if (!int.TryParse(input, out enteredPin))
                {
                    Console.WriteLine("Invalid Input! Enter numbers only.");
                    continue;
                }

                if (user.CheckPin(enteredPin))
                {
                    loginSuccess = true;
                    Console.WriteLine("Login Successful!");
                    break;
                }
                else
                {
                    attempts++;
                    Console.WriteLine("Wrong PIN! Attempts Left: " + (3 - attempts));
                }
            }

            if (!loginSuccess)
            {
                Console.WriteLine("Account Locked. Try Again Later.");
                return;
            }

            int choice = 0;
            double amount = 0;

            //  ATM Menu Loop
            do
            {
                Console.WriteLine("\n1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Account Details");
                Console.WriteLine("5. Exit");
                Console.Write("Enter Your Choice: ");

                string? choiceInput = Console.ReadLine();

                if (!int.TryParse(choiceInput, out choice))
                {
                    Console.WriteLine("Invalid Choice! Enter numbers only.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        user.CheckBalance();
                        break;

                    case 2:
                        Console.Write("Enter Deposit Amount: ");
                        string? depositInput = Console.ReadLine();

                        if (double.TryParse(depositInput, out amount))
                        {
                            user.Deposit(amount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Amount!");
                        }
                        break;

                    case 3:
                        Console.Write("Enter Withdraw Amount: ");
                        string? withdrawInput = Console.ReadLine();

                        if (double.TryParse(withdrawInput, out amount))
                        {
                            user.Withdraw(amount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Amount!");
                        }
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
    }*/

}
