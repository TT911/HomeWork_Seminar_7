// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Индекс строки: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Индекс столбца: ");
int column = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,] array = GetArray(6, 6, -11, 10);
PrintArray(array);
Console.WriteLine();

if (row < 7 && column < 7)
{
    object target = array.GetValue(row,column);
    Console.WriteLine($"i = {row}, j = {column} -> {target}");
}
else
{
    Console.WriteLine($"i = {row}, j = {column} -> такого числа нет");
}
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for(int j=0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

