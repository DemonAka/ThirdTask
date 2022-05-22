using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sumCards = 0;

            Console.WriteLine("Доброго времени суток, дорогой гость. Уточните, сколько карт у вас на руке:  ");
            int numberCards = int.Parse(Console.ReadLine());
            Console.WriteLine("Внимание!!! J - Валет, Q - Дама, K - Кароль, T - туз");
            for (int i = 1; i <= numberCards; i++)
            {
                Console.WriteLine($"Введите {i} карту : ");
                string cards = Console.ReadLine(); //Используем тип string, вместо char, так как карта '10' имеет два символа. 
                switch (cards)
                {
                    case "2": sumCards = sumCards + 2; 
                        break;
                    case "3": sumCards = sumCards + 3;
                        break;
                    case "4": sumCards = sumCards + 4;
                        break;
                    case "5": sumCards = sumCards + 5;
                        break;
                    case "6": sumCards = sumCards + 6;
                        break;
                    case "7": sumCards = sumCards + 7;
                        break;
                    case "8": sumCards = sumCards + 8;
                        break;
                    case "9": sumCards = sumCards + 9;
                        break;
                    case "10": sumCards = sumCards + 10;
                        break;
                    case "j": sumCards = sumCards + 10;
                        break;
                    case "q": sumCards = sumCards + 10;
                        break;
                    case "k": sumCards = sumCards + 10;
                        break;
                    case "t": sumCards = sumCards + 10;
                        break;
                    case "J": sumCards = sumCards + 10;     //Повторно вводим case c J,Q,K,T так как пользователь может ввести как строчные так и прописные буквы
                        break;
                    case "Q": sumCards = sumCards + 10;
                        break;
                    case "K": sumCards = sumCards + 10;
                        break;
                    case "T": sumCards = sumCards + 10;
                        break;
                    default:
                        Console.WriteLine("Такой карты не существует");
                        i--;
                        break;
                }
            }
            Console.WriteLine($"Ваш набор карт равен {sumCards} очкам");
            if (sumCards > 21) Console.WriteLine("Вы проиграли");
            else if (sumCards == 21) Console.WriteLine("Вы выйграли!!! Поздравляю");
            else Console.WriteLine("У вас еще есть надежды на победу. Можете взять еще карту, а то и две");

            Console.ReadKey();
        }
    }
}
