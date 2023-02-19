// See https://aka.ms/new-console-template for more information
class Programm
{
    /// <summary>
    /// Лабораторная работа 3. Задание 7.4
    /// Дан массив из N элементов (N — четное). Распечатать
    /// его в следующем порядке: a1, aN, a2, aN–1, ... , aN/2, aN/2+1.
    /// </summary>
    public static void Main()
    {
        int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int n = array.Length - 1;
        for (int i = 0; i < array.Length / 2; i++)
        {
            Console.WriteLine($"{array[i]}");
            Console.WriteLine($"{array[n - i]}");
        }
    }
 
    
}
