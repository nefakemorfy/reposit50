using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            byte n = byte.Parse(Console.ReadLine());
            double [] array = new double[n];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = -50 + (50 - (-50)) * rnd.NextDouble();
                Console.WriteLine($"array [{i}]={array[i]}");
            }
            Console.WriteLine($"array[0]={array[0]}\narray[{array.Length-1}]={array[array.Length-1]}");
            Console.Read();
        }
    }
}
