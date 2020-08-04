using System;

namespace TryingOutCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int value = 0; value < 10; value++)
            {
                if (value == 7)
                {
                    Console.WriteLine("Found 7");
                    break;
                }
                else    
                    Console.WriteLine("Current value {0}, 7 not found!", value);
            }      
        }
    }
}
