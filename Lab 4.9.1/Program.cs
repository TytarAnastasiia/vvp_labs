// See https://aka.ms/new-console-template for more information

/// <summary>
/// Лабораторная работа 4, задание 9.1
/// Даны числа a,b,c,d. Получить x=max(a,b), y=max(c,d), z=max(x,y).
/// Вычисление max(k, m) (большего из двух чисел k, m) оформить функцией.
/// </summary>
    
    int GetMax2(int v1, int v2)
    {
        if (v1 > v2) return v1;
        return v2;
    }
    
    int GetMax4(int a, int b, int c, int d)
    {
        int x = GetMax2(a,b);
        int y = GetMax2(c,d);
        int z = GetMax2(x,y);
        return z;
    }

int a = 500;
int b = 3;
int c = 24;
int d = 16;
int max = GetMax4(a, b, c, d);
Console.WriteLine("a = 500; b = 3; c = 24; d = 16;");
Console.WriteLine($"Максимальное значение = {max}");

