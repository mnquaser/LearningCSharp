using System;
using System.Linq;
using System.Collections.Generic;

namespace WayTooLongWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> givenWords = new List<string>();
            int lineCount = Convert.ToInt32(Console.ReadLine());
            foreach (var item in Enumerable.Range(0, lineCount))
            {
                givenWords.Add((Console.ReadLine()));
            }
            foreach (string item in givenWords)
            {
                if (item.Length > 10)
                    Console.WriteLine("{0}{1}{2}", item[0], item.Length - 2, item[item.Length - 1]);
                else
                    Console.WriteLine(item);
            }
        }
    }
}
