// https://codeforces.com/problemset/problem/4/A

using System;

namespace Watermelon
{
    class Program
    {
        static void Main(string[] args)
        {
            int Watermelon = Convert.ToInt32(Console.ReadLine());
            string result = (Watermelon % 2 == 0 && Watermelon > 2 ) ? "YES" : "NO";
            Console.WriteLine(result);
         }   
    }
}
