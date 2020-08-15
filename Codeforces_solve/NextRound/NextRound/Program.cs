using System;

namespace NextRound
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split(' ');
            var n = int.Parse(data[0]);
            var k = int.Parse(data[1]);

            var contenstent = Console.ReadLine().Split(' ');
            int nextRound = 0;
            var kScore = int.Parse(contenstent[k - 1]);
            foreach (var every in contenstent)
            {
                var intEvery = int.Parse(every);
                if (intEvery != 0 && intEvery >= kScore)
                {
                    nextRound++;
                }
            }
            Console.WriteLine(nextRound);
            
        }
    }
}
