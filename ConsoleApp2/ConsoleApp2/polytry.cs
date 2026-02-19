using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class welcomeMessage {
        public virtual void paymode(int amount)
        {
            Console.WriteLine("Welcome to the Madhan Payment System");
        }
    }

    class card : welcomeMessage
    {
        public override void paymode(int amount)
        {
            Console.WriteLine("This is the card payment method", amount);
        }
    }

    class upi: welcomeMessage
    {
        public override void paymode(int amount)
        {
            Console.WriteLine("this is the upi payment method", amount);
        }
    }

    class cash : welcomeMessage
    {
        public override void paymode(int amount)
        {
            Console.WriteLine("this is the cash payment method", amount);
        }
    }



    class program { 
        static void Main(string[] args) {
            welcomeMessage obj1 = new cash();
            obj1.paymode(1000);
            //welcomeMessage message1 = new welcomeMessage();

            //message1.displayMessage();
        }
    }
}