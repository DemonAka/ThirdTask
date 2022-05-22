using System;

namespace ThirdTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Просьа введите любое целое число");
            int number = int.Parse(Console.ReadLine());
            int count = 1;
            bool division = false;
            while (count < number -1)
            {
                /* Сразу добавляем единицу, так как простое число - это число, которое делится на 1 и на само себя.
               А в задании требуется начинать цикл с 1. В таком случае, любое число, будет делится на 1 и в division - всегда будет true */
                count++;
              
                if (number % count == 0)
                {
                    division = true;
                }
               
            }

            if (division == true) Console.WriteLine($"Введеное число {number} не является простым");
            else Console.WriteLine($"Введеное число {number} является простым");
            Console.ReadKey();
        }
    }
}
