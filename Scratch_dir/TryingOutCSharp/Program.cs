using Microsoft.VisualBasic;
using System;
using System.Linq;

namespace TryingOutCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* WriteLine
            Console.WriteLine("Hello World"); /*

            /* Write
            Console.Write("Hello ");
            Console.Write("World"); */

            /* ReadLine
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Welcome {0}.", name); */

            /* if
            String msg = "";
            Console.Write("Choose a door 1 or 2 : ");
            String userValue = Console.ReadLine();
            if (userValue == "1")
            {
                msg = "You win";
            }
            else
            {
                msg = "You are dead";
            }
            Console.WriteLine(msg); */

            /* if -shorthand
            
            Console.Write("Choose a door 1 or 2 : ");
            String userValue = Console.ReadLine();
            string msg = (userValue == "1") ? "You win" : "You lose";
            Console.WriteLine(msg); 
            */


            /* for loop and break
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7)
                {
                    Console.WriteLine("Breaking up");
                    break;
                }
            }
            */


            /* foreach / for -shorthand , Enumerable.Range
            foreach (int item in Enumerable.Range(0, 10))
            {
                Console.WriteLine(item);
                if (item == 7)
                {
                    Console.WriteLine("Breaking up");
                    break;
                }
            }
            */


            /* basic array
            string[] books = new string[] {"Angles and Demons", "The da'Vinci code", "The lost symbol",
                                            "Inferno", "Origins"};
            int indexNum = 1;
            foreach (string book in books)
            {
                Console.WriteLine("{0}. {1}", indexNum, book);
                indexNum++;
            }
            */

            /* char array
            String quote = "Whatever happens, happens";
            char[] charArray = quote.ToCharArray();
            Console.WriteLine(quote);
            Array.Reverse(charArray);

            foreach (char quoteChar in charArray)
            {
                Console.Write(quoteChar);
            }
            */

            // HelloWorld();
            // Welcome("Rafef");
            Console.WriteLine("Your name is {0}", Name());
        }

        /* defining a simple method 1
        private static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }
        */


        /* defining a simple method 2 
        private static void Welcome(string name)
        {
            Console.WriteLine("Welcome {0}", name);
        }
        */

        private static string Name()
        {
            Console.Write("Type your name : ");
            string name = Console.ReadLine();
            return name;
        }
    }
}
