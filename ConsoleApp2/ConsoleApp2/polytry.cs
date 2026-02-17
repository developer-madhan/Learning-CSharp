using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class welcomeMessage {
        public void displayMessage()
        {
            Console.WriteLine("Welcome to the Madhan Payment System");
        }
    }



    class program { 
        static void Main(string[] args) {
            welcomeMessage message1 = new welcomeMessage();

            message1.displayMessage();
        }
    }
}