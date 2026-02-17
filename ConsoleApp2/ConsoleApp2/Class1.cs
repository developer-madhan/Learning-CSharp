using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        DemoClass myObj = new DemoClass();
    //        myObj.myMethod();
    //        myObj.myOtherMethod();
    //    }
    //}
    //// Abstract class
    //abstract class Animal
    //{
    //    // Abstract method (does not have a body)
    //    public abstract void animalSound();
    //    // Regular method
    //    public void sleep()
    //    {
    //        Console.WriteLine("Zzz");
    //    }
    //}

    //// Derived class (inherit from Animal)
    //class Pig : Animal
    //{
    //    public override void animalSound()
    //    {
    //        // The body of animalSound() is provided here
    //        Console.WriteLine("The pig says: wee wee");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Pig myPig = new Pig();  // Create a Pig object
    //        myPig.animalSound();
    //        myPig.sleep();
    //    }
    //}
}
