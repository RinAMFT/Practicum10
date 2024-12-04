using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        //Task2
        public static double Function(int a, int b)
        {
            return (Math.Sqrt(a) + a / Math.Sqrt(b) + b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"x = {Function(5, 7) + Function(12, 8) + Function(19, 2)}");
            Console.ReadKey();
        }
    }
}
