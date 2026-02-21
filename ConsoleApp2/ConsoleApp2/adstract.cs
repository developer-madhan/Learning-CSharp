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
            public abstract void Withdraw();
            public abstract void Deposit();
            public abstract void CheckBalance();
        }

        class MyATM : ATM
        {
            public override void Withdraw()
            {
                Console.WriteLine("Withdraw method called");
            }
            public override void Deposit()
            {
                Console.WriteLine("Deposit method called");
            }
            public override void CheckBalance()
            {
                Console.WriteLine("Check Balance method called");
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
                        Console.WriteLine("You have chosen to Withdraw");
                        atm.Withdraw();
                        break;
                    case 2:
                        Console.WriteLine("You have chosen to Deposit");
                        atm.Deposit();
                        break;
                    case 3:
                        Console.WriteLine("You have chosen to Check Balance");
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
