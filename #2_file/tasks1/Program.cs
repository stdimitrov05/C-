using System;
using System.Linq;

namespace tasks1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Imporiting data  */
            /* var numberInput = System.Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            System.Console.WriteLine(string.Join(" " , numberInput.Min()));*/
            /* Problem 1.	Намиране на най-малко число 
      Определете сложността (максимания брой стъпки) на програма, която чете от конзолата последователност от цели числа на един ред, разделени с интервал. Намерете най-малкото от тях и го изведете.
      Подсказка
     1.	В променлива minimum запишете първото число
    2.	Сравнявайте това число с всички останали (от второто до последното) и ако някое от тях е по-малко, то в minimum запазете неговата стойност
    3.	Изведете стйността на minimum.
 */
 
            System
                .Console
                .WriteLine(string
                    .Join(" ",
                    System
                        .Console
                        .ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray()
                        .Min()));
                        
        }
    }
}
