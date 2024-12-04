using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        //Task4
        public static int Max(int x, int y, int z)
        {
            return Math.Max(x, Math.Max(y, z));
        }

        static void Main(string[] args)
        {
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("z = ");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine(Max(x, y, z));
            Console.ReadKey();
        }

    }
}
