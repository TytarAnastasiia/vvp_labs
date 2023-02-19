
//Лабораторная работа 2, задание 6.1.
//Рассчитать: x - x2/2! - x3/3! - x4/4!... (при 0<x<1)
Console.WriteLine("Лабораторная 2. Задание 6.1");
Console.Write("Введите число x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"x={x}");
if (x < 0)
{
    Console.WriteLine("Введенное значение x не соответствует условию");
    return;
}
else if (x > 1)
{
    Console.WriteLine("Введенное значение x не соответствует условию");
    return;
}

Console.Write("Введите число E: ");
double e = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"E={e}");
if (e > x)
{
    Console.WriteLine("Введенное значение E не соответствует условию");
    return;
}

int i = 0;
double r = 0;
double v = 1;
while (Math.Abs(v) >= e)
{
    i++;
    double f = 1;
    for (int j = 1; j <= i; j++)
    {
        f *= j;
    }

    v = Math.Pow(x, i) / f;

    if (i % 2 == 0) r -= v;
    else r += v;
};
Console.WriteLine($"Результат: {r}");
double y = Math.Log(x + 1);
if (r > y) Console.WriteLine($"Результат больше {y}");
else if (r < y) Console.WriteLine($"Результат меньше {y}");
else Console.WriteLine($"Результат равно {y}");
