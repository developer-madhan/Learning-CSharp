using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class program
    {


        static void Main(string[] args)
        {
            //Console.WriteLine("this is the abstract class example");

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
                        break;
                    case 2:
                        Console.WriteLine("You have chosen to Deposit");
                        break;
                    case 3:
                        Console.WriteLine("You have chosen to Check Balance");
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
