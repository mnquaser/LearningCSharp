using System;

namespace TheatreSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var n = decimal.Parse(input[0]);
            var m = decimal.Parse(input[1]);
            var a = decimal.Parse(input[2]);
            var widthStone = Math.Ceiling(m/a);
            var heightStone = Math.Ceiling(n/a);


            Console.WriteLine(heightStone * widthStone);
        }
    }
}
