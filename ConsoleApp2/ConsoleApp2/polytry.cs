using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class welcomeMessage {
        public virtual void paymode(double amount)
        {
            Console.WriteLine("Welcome to the Madhan Payment System");
        }
    }

    class card : welcomeMessage
    {
        public override void paymode(double amount)
        {
            Console.WriteLine("This is the card payment method", amount);
        }
    }

    class upi: welcomeMessage
    {
        public override void paymode(double amount)
        {
            Console.WriteLine("this is the upi payment method", amount);
        }
    }

    class cash : welcomeMessage
    {
        public override void paymode(double amount)
        {
            Console.WriteLine("this is the cash payment method", amount);
        }
    }



    class program { 
        static void Main(string[] args) {
            welcomeMessage obj1 = new cash();
            //obj1.paymode(1000);

            Console.Write("Enter amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nChoose Payment Mode:");
            Console.WriteLine("1. Card");
            Console.WriteLine("2. UPI");
            Console.WriteLine("3. Cash");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    obj1 = new card();
                    break;
                case 2:
                    obj1 = new upi();
                    break;
                case 3:
                    obj1 = new cash();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            obj1.paymode(amount);


            //welcomeMessage message1 = new welcomeMessage();

            //message1.displayMessage();
        }
    }
}