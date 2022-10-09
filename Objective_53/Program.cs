// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

double[,] a = new double[rows,columns];
double[] b = new double[rows];

for (int i = 0, k = 0; i < rows; i++)
{
    double sum = 0;
    for (int j=0; j < columns; j++)
    {
        sum += array[i,j];
    }
    b[k]=sum/rows;
    Console.WriteLine("Среднее арифметическое столбца "+(i+1)+" равно: "+b[k]);
    k++;
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