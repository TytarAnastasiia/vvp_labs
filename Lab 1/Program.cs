using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Program
    {
        static void Main()
        {
            //Найти массу x литров молока, если известно, что плотность молока р кг/м3
            Console.WriteLine("Лабораторная 1, задание 3.1");
            double x = 0.007;
            double p = 1030;
            double m = x * p;
            Console.WriteLine($"x={x} p={p} m=x*p={m}");

            //Даны числа a, b, c . Проверить, выполняется ли неравенство a<b<c.
            //Вывести об этом сообщение.
            Console.WriteLine("Лабораторная 1, задание 4.1");
            Console.Write("Введите число a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"a={a}");

            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"b={b}");

            Console.Write("Введите число c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"c={c}");

            if (a < b && b < c)
            {
                Console.WriteLine("Равенство a<b<c - верно");
            }
            else
            {
                Console.WriteLine("Равенство a<b<c - невено");
            }
            Console.ReadLine();
        }
    }
}
