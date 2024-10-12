using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_zavd2s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0.1;
            double E = Math.Pow(10, -5);

            double sum = 0;
            int n = 1;
            double item;

            do
            {
                item = (Math.Pow(-1, n) * n * Math.Sqrt(n * x)) / Factorial(2 * n + 1);
                sum += item;

                Console.WriteLine($"Iтерацiя {n}:");
                Console.WriteLine($"Член ряду: {item}");
                Console.WriteLine($"Часткова сума: {sum}");
                Console.WriteLine($"Абсолютна похибка: {Math.Abs(item / sum)}");

                n++;
            } while (Math.Abs(item / sum) >= E);

            Console.WriteLine($"Величина накопиченої суми ряду S1 {sum}");
            Console.WriteLine($"Номер iтерацiї n={n}");
            Console.WriteLine($"Величина поточного ряду item={item}");
            Console.WriteLine($"Досягнута на поточнiй iтерацiї похибка е={Math.Abs(item / sum)}");
        }
        static double Factorial(int n)
        {
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
