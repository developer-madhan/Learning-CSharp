using System;

namespace ConsoleApp2
{
    public class ATM
    {
        //  Private fields
        private decimal balance;
        private int pin;

        // Encapsulated Property
        public decimal Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        //  Constructor
        public ATM(decimal initialBalance, int userPin)
        {
            Balance = initialBalance;   // using property
            pin = userPin;
        }

        //  PIN validation
        public bool ValidatePin()
        {
            int attempts = 0;

            while (attempts < 3)
            {
                Console.Write("Enter PIN: ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int enteredPin) && enteredPin == pin)
                {
                    Console.WriteLine("Login Successful\n");
                    return true;
                }

                attempts++;
                Console.WriteLine($"Wrong PIN! Attempts left: {3 - attempts}");
            }

            Console.WriteLine("Account Locked");
            return false;
        }

        //  Deposit
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount");
                return;
            }

            Balance += amount;   // property used
            Console.WriteLine($"{amount} Deposited");
        }

        // 💸 Withdraw
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient Balance");
                return;
            }

            Balance -= amount;   // property used
            Console.WriteLine($"{amount} Withdrawn");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM(10000, 1234);

            if (!atm.ValidatePin())
                return;

            while (true)
            {
                Console.WriteLine("\n1.Check Balance  2.Deposit  3.Withdraw  4.Exit");
                Console.Write("Choose: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Balance: {atm.Balance}");
                        break;

                    case "2":
                        Console.Write("Deposit Amount: ");
                        atm.Deposit(Convert.ToDecimal(Console.ReadLine()));
                        break;

                    case "3":
                        Console.Write("Withdraw Amount: ");
                        atm.Withdraw(Convert.ToDecimal(Console.ReadLine()));
                        break;

                    case "4":
                        return;
                }
            }
        }
    }
}