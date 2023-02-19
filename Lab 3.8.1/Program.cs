// See https://aka.ms/new-console-template for more information

Console.WriteLine("Лабораторная работа 3, задание 8.1");

/// <summary>
/// Дана матрица 5х5. Для данного натурального М найти сумму 
/// тех элементов матрицы, сумма индексов которых равна М.
/// </summary>

int [,] array = new int [5,5] 
{ { 1, 2, 3, 4, 5 },{ 5, 6, 7, 8, 9 },{ 3, 5, 4, 3, 5 },{ 1, 2, 3, 1, 2 },{ 7, 1, 2, 8, 6 } };
int m = 5;
int sum = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if ((i + j) == m)
        {
            Console.WriteLine($"Выбираем элемент [{i},{j}] = {array[i, j]}");
            sum += array[i, j];
        }
    };
};
Console.WriteLine($"Сумма выбранных элементов = {sum}");



