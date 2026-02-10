using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Logger
    {
        private static Logger instance;

        private Logger()
        {
            Console.WriteLine("Logger Created");
        }
        public static Logger GetLogger()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}
