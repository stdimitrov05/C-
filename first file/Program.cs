using System;
using System.Collections.Generic;
using System.Linq;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers =
                System.Console.ReadLine().Split().Select(int.Parse).ToArray();

            int secondInput = int.Parse(System.Console.ReadLine());

            number (inputNumbers, secondInput);
        }

        static void number(int[] inputNumbers, int secondInput)
        {
            var numberFromArr =
                Array.Exists(inputNumbers, x => x == secondInput);

            if (numberFromArr == true)
            {
                System.Console.WriteLine("{0} Exists in the List", secondInput);
            }
            else
            {
                System
                    .Console
                    .WriteLine("{0} Not exists in the List", secondInput);
            }
        }
    }
}
