using System;
using System.Linq;

namespace team
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int imp_problems = 0;
            foreach (int item in Enumerable.Range(0,n))
            {
                var data = Console.ReadLine().Split(' ');
                var a = int.Parse(data[0]);
                var b = int.Parse(data[1]);
                var c = int.Parse(data[2]);
                int sum = a + b + c;
                if (sum > 1)
                {
                    imp_problems++;
                }
            }
            Console.WriteLine(imp_problems);
        }
    }
}
