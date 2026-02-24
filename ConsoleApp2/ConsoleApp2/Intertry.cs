using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int attempts = 0;
            int enteredPin = 0;
            bool loginSuccess = false;

            while (attempts < 3) 
            {
                Console.WriteLine("Enter Your PIN:");
                string? inputPin = Console.ReadLine();

                if (!int.TryParse(inputPin, out enteredPin)) 
                {
                    Console.WriteLine("Invalid Input! Enter numbers only.");
                    continue;
                }
                if (enteredPin == 1234)
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
        }
    }
}
