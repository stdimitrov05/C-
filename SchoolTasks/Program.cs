using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Напишете програма, която чете от конзолата възходяща последователност от цели числа на един ред, 
            разделени с интервал и на втори ред число, което се вмъква на такава позиция, че новополучения масив 
            отново да е възходящо подреден. Изведете:
              a)Новополучения масив 
              b)Двата масива – този, преди вмъкването и другия – след вмъкването */
            /* Input */
            var numberInput =
                System
                    .Console
                    .ReadLine()
                    .Split(' ')
                    .Where(x => x != null)
                    .Select(int.Parse)
                    .ToList();

            /* second Input */
            int secontNumber = int.Parse(System.Console.ReadLine());

            Algorithm (numberInput, secontNumber);
        }

        private static void Algorithm(List<int> numberInput, int secontNumber)
        {
            /* copy oringal list  */
            List<int> copyList = numberInput.Distinct().ToList();

            /* Insert Numbers in list*/
            numberInput.Insert(numberInput.Count, secontNumber);

            /*  Sorting from Int.MaxValue to int.MinValue*/
            numberInput.Sort();
            Exit (numberInput, copyList);
        }

        private static void Exit(List<int> numberInput, List<int> copyList)
        {
            System.Console.WriteLine("New List: ");
            System.Console.Write(string.Join(" ", numberInput));
            System.Console.WriteLine("\nOld List and New List: ");
            System.Console.WriteLine(string.Join(" ", copyList));
            System.Console.WriteLine(string.Join(" ", numberInput));
        }
    }
}
