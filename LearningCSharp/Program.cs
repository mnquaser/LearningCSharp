using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //program1 HelloWorld
            Console.WriteLine("Hello World");
            Console.ReadLine();

            //program2 Variables
            int x = 32;
            int y = x + 2;
            Console.WriteLine(y);
            Console.ReadLine();

            //program3 Greetings
            Console.WriteLine("What is your name ?");
            Console.Write("Type your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + ". How are yo? ");
        }
    }
}
