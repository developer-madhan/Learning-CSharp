using System;

namespace ConsoleApp2
{
    //  Interface
    public interface IATMOperations
    {
        void CheckBalance();
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }

    //  ATM Implementation
    public class ATM : IATMOperations
    {
        private decimal balance = 10000; // default balance

        public void CheckBalance()
        {
            Console.WriteLine($"Current Balance: {balance}");
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"₹{amount} Deposited Successfully");
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
                Console.WriteLine($"{amount} Withdrawn Successfully");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int attempts = 0;
            int enteredPin = 0;
            bool loginSuccess = false;

            //  PIN Login
            while (attempts < 3)
            {
                Console.Write("Enter Your PIN: ");
                string? inputPin = Console.ReadLine();

                if (!int.TryParse(inputPin, out enteredPin))
                {
                    Console.WriteLine("Invalid Input! Numbers only.");
                    continue;
                }

                if (enteredPin == 1234)
                {
                    loginSuccess = true;
                    Console.WriteLine("Login Successful!\n");
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
                Console.WriteLine("Account Locked.");
                return;
            }

            //  ATM Menu
            IATMOperations atm = new ATM();

            while (true)
            {
                Console.WriteLine("\n===== ATM MENU =====");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Choose Option: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        atm.CheckBalance();
                        break;

                    case "2":
                        Console.Write("Enter Deposit Amount: ");
                        decimal deposit = Convert.ToDecimal(Console.ReadLine());
                        atm.Deposit(deposit);
                        break;

                    case "3":
                        Console.Write("Enter Withdraw Amount: ");
                        decimal withdraw = Convert.ToDecimal(Console.ReadLine());
                        atm.Withdraw(withdraw);
                        break;

                    case "4":
                        Console.WriteLine("Thank You! Visit Again.");
                        return;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }
    }
}