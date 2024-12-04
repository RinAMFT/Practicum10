using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        //Task5
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d = ");
            int d = int.Parse(Console.ReadLine());

            Console.Write($"S = {Max1(a, b) + Max2(c, d)}");
            Console.ReadKey();
        }

        public static int Max1(int a, int b)
        {
            return Math.Max(a, b);

        }
        public static int Max2(int c, int d)
        {
            return Math.Max(c, d);
        }
    }
}
