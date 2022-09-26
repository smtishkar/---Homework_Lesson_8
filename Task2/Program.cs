// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int columns = 5;
int rows = 5;

int[,] array = GetArray(columns, rows, 0, 9);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Сумма элементов каждой строки:");
Console.WriteLine();
int[] newarray = SumLineArray(array, columns);
Console.WriteLine();
Console.WriteLine($"Строкой с наименьшей суммой элементов, является строка с индекосм - {(MinFind(newarray))}");



int[] SumLineArray(int[,] myarray, int columns)
{
    int[] arr = new int[columns];

    for (int i = 0; i < myarray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < myarray.GetLength(1); j++)
        {
            sum = sum + myarray[i, j];
            arr[i] = sum;
        }
        Console.WriteLine($"{sum} ");
    }
    return arr;
}

int MinFind(int[] array)
{
    int min = 0;
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min == 0) min = array[i];
        if (min > array[i])
        {
            min = array[i];
            index = i;         
        }
    }
    return index;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    }
    return arr;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


