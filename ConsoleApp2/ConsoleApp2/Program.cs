namespace ConsoleApp2
{
    // Create a Car class
    class Car
    {
        public string model;

        // Create a class constructor with a parameter
        public Car(string modelName)
        {
            model = modelName;
        }

        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang");
            Console.WriteLine(Ford.model);
        }
    }

    // Outputs "Mustang"


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Car Ford = new Car();
    //        Ford.model = "Mustang";
    //        Ford.color = "red";
    //        Ford.year = 1969;

    //        Car Opel = new Car();
    //        Opel.model = "Astra";
    //        Opel.color = "white";
    //        Opel.year = 2005;

    //        Console.WriteLine(Ford.model);
    //        Console.WriteLine(Opel.model);
    //    }
    //}

    //class Car
    //{
    //    string model;
    //    string color;
    //    int year;

    //    static void Main(string[] args)
    //    {
    //        Car Ford = new Car();
    //        Ford.model = "Mustang";
    //        Ford.color = "red";
    //        Ford.year = 1969;

    //        Car Opel = new Car();
    //        Opel.model = "Astra";
    //        Opel.color = "white";
    //        Opel.year = 2005;

    //        Console.WriteLine(Ford.model);
    //        Console.WriteLine(Opel.model);
    //    }
    //}
}
