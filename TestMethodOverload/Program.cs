using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {







            printMessage();
            printMessage("Hi!");
            printMessage("Yo!", 5);
            printMessage("Bro!", 3L);

            int x = 10;
            printPlusOne(x);
        }

        public static void printPlusOne(int input)
        {
            input += 1;

            Console.WriteLine(input);
        }

        public static void printMessage()
        {
            Console.WriteLine("Hello!");
        }

        public static void printMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void printMessage(string message, int freq)
        {
            for (int i = 1; i <= freq; i++)
            {
                Console.WriteLine(message);
            }
        }

        public static void printMessage(string message, long freq)
        {
            for (int i = 1; i <= freq; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
