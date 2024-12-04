using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        //Task6
        static void Main(string[] args)
        {
            Console.Write("Напишите число от 1 до 7: ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
            }

            if (num > 0) ;
            else Console.WriteLine("Ошибка! Вы ввели неккоректное число!");


            if (num < 7) ;
            else Console.WriteLine("Ошибка! Вы ввели неккоректное число!");

            Console.ReadKey();
        }
    }
}
