using System;
using System.Linq;

namespace tasks5
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers =
                System.Console.ReadLine().Split().Select(int.Parse).ToList();

            System.Console.WriteLine("Sum= {0}; ", inputNumbers.Sum());
            System.Console.Write("Average={0:f2}", inputNumbers.Average());
        }
    }
}
