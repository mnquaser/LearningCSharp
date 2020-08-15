using System;
using System.Text;

namespace StringTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine().ToLower());
            var vowels = "aeiouy".ToCharArray();
            var consonent = "bcdfghjklmnpqrstuvwxz".ToCharArray();
            foreach (char item in vowels)
            {
                string i =  item.ToString();
                if (input.ToString().Contains(i))
                {
                    input.Replace(i, "");
                }
            }

            foreach (char item  in consonent)
            {
                string i = item.ToString();
                if (input.ToString().Contains(i))
                {
                    input.Replace(i, string.Format(".{0}", i));
                }
            }
            Console.WriteLine(input);
        }
    }
}
