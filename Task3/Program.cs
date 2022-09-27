// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



Console.Clear();
int columns1 = 2;
int rows1 = 3;
int columns2 = 3;
int rows2 = 2;


int[,] firstMatrix = GetArray(rows1, columns1, 1, 4);
int[,] secondMatrix = GetArray(rows2, columns2, 1, 4);
Console.WriteLine("Матрица №2");        // Для удобства отображения вывел сначала вторую матрицу
PrintArray(secondMatrix);
Console.WriteLine();
Console.WriteLine("Матрица №1");
PrintArray(firstMatrix);
Console.WriteLine();


if (rows1 != columns2)
{
    Console.WriteLine("Матрицы нельзя перемножить");
}
else
{
    int[,] thirddMatrix = MatrixProduction(firstMatrix, secondMatrix);
    Console.WriteLine();
    PrintArray(thirddMatrix);
}

int[,] MatrixProduction(int[,] array1, int[,] array2)
{
    int[,] arr = new int[rows1, columns2];

    for (int i = 0; i < array2.GetLength(1); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            arr[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {          
                arr[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return arr;

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
