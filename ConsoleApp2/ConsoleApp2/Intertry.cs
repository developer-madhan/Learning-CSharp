using System;

namespace ConsoleApp2
{
    //  Interface 1
    public interface IATMOperations
    {
        void CheckBalance();
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }

    //  Interface 2
    public interface ISecurity
    {
        bool ValidatePin();
    }

    //  Interface 3
    public interface IReceipt
    {
        void PrintReceipt(string message);
    }

    //  Multiple inheritance using interfaces
    public class ATM : IATMOperations, ISecurity, IReceipt
    {
        private decimal balance = 10000;
        private const int pin = 1234;

        //  PIN Validation
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

        public void CheckBalance()
        {
            Console.WriteLine($"Balance: {balance}");
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
            PrintReceipt($"{amount} Deposited");
        }

        public void Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                balance -= amount;
                PrintReceipt($"{amount} Withdrawn");
            }
        }

        public void PrintReceipt(string message)
        {
            Console.WriteLine("----- RECEIPT -----");
            Console.WriteLine(message);
            Console.WriteLine($"Available Balance: {balance}");
            Console.WriteLine("-------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();

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
                        atm.CheckBalance();
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

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}