//Лабораторная работа 2, задание 5.1.
//Рассчитать:  cos x + cos x2 + cos x3 + ... + cos xn.
Console.WriteLine("Лабораторная работа 2, задание 5.1");
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"n={n}");

Console.Write("Введите число x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"x={x}");

double sum = 0;
for (int i = 1; i <= n; i++)
{
    sum += Math.Cos(Math.Pow(x, i));
    Console.WriteLine($"Ответ: {sum}");
}
Console.ReadLine();
