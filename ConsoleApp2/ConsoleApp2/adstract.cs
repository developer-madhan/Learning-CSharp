using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class program
    {
        abstract class ATM
        {
            protected double balance = 10000;
            public abstract void Withdraw(double amount);
            public abstract void Deposit(double amount);
            public abstract void CheckBalance();
        }

        class MyATM : ATM
        {
            public override void Withdraw(double amount)
            {
                //Console.WriteLine("Withdraw method called");
                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine("Withdraw Successful");
                }
                else
                {
                    Console.WriteLine("Insufficient Balance");
                }
            }

            public override void Deposit(double amount)
            {
                //Console.WriteLine("Deposit method called");
                balance += amount;
                Console.WriteLine("Deposit Successful");
            }

            public override void CheckBalance()
            {
                //Console.WriteLine("Check Balance method called");
                Console.WriteLine("Balance: " + balance);
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("this is the abstract class example");

            ATM atm = new MyATM();

            while (true)
            {
                Console.WriteLine("\n === ATM MENU ===");
                Console.WriteLine("1.Withdraw");
                Console.WriteLine("2.Deposit");
                Console.WriteLine("3.Check Balance");
                Console.WriteLine("4.Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        //Console.WriteLine("You have chosen to Withdraw");
                        Console.Write("Enter amount: ");
                        double w = Convert.ToDouble(Console.ReadLine());
                        atm.Withdraw(w);
                        break;
                    case 2:
                        //Console.WriteLine("You have chosen to Deposit");
                        Console.Write("Enter amount: ");
                        double d = Convert.ToDouble(Console.ReadLine());
                        atm.Deposit(d);
                        break;
                    case 3:
                        //Console.WriteLine("You have chosen to Check Balance");
                        atm.CheckBalance();
                        break;
                    case 4:
                        Console.WriteLine("Exiting the program. Thank you!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
