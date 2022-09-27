// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



int[,] array = GetArray(5, 5, 0, 9);
PrintArray(array);
int[,] newArray = CorrectArray(array);
Console.WriteLine();
PrintArray(newArray);

int[,] CorrectArray(int[,] myarray)
{
    int rows = myarray.GetLength(0);
    int columns = myarray.GetLength(1);

    for (int i = 0; i < myarray.GetLength(0); i++)
    {
        int iteration = 0;
        while (iteration < myarray.GetLength(1))
        {
            int min = 0;
            for (int j = 0; j < myarray.GetLength(1) - 1; j++)
            {
                if (myarray[i, j] < myarray[i, j + 1])
                {
                    min = myarray[i, j];
                    myarray[i, j] = myarray[i, j + 1];
                    myarray[i, j + 1] = min;
                }
            }
            iteration++;
        }
    }
    return myarray;
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
