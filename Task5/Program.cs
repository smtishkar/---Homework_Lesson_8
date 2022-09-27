// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.Clear();
int columns = 4;
int rows = 4;
int step = 1;
int i = 0;
int j = 0;
// int[,] spiralMatrix = new int[rows, columns];
int maxSteps = columns * rows;

int[,] array = GetSpiralMatrix(rows, columns);
PrintArray(array);
Console.WriteLine();


int[,] GetSpiralMatrix(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    while (step <= (maxSteps))
    {
        array[i, j] = step;
        if (i <= j + 1 && i + j < (columns - 1))                   
            j++;
        else if (i < j && i + j >= (rows - 1))
            i++;
        else if (i >= j && i + j > (columns - 1))
            j--;
        else
            i--;
        step++;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}