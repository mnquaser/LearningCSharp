using System;

namespace TryingOutCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string[] books = new string[] { "Angels and Demons", "The  Da'Vinci Code,",
                                                "The Lost Symbols", "Inferno", "Origins" };

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i]);
            }
            //2
            foreach (string book in books)
            {
                Console.WriteLine("this is with 'foreach' : {0}", book);
            }
            //3
            string qoute = "Whatever happens, happens.";
            char[] chQoute = qoute.ToCharArray();
            Array.Reverse(chQoute);
            Console.WriteLine(qoute);
            foreach (char item in chQoute)
            {
                Console.Write(item);
            }
        }
    }
}
