using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static double Function(int a)
        {
            return (Math.Sqrt(a) + a / 2);
        }
             static void Main(string[] args)
           {
            //Task1
            Console.WriteLine($"x = {Function(5) + Function(12) + Function(19)}");
            Console.ReadKey();
            }
        }
    }
