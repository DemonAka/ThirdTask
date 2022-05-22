using System;

namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"Число {number} является четным числом!");
            }
            else
            {
                Console.WriteLine($"Число {number} является нечетынм числом!");
            }
            Console.ReadKey();
        }
    }
}