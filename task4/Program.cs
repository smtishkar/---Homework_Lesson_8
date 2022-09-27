﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.Clear();
int columns = 3;
int rows = 4;
int depth = 3;


int[,,] array = GetArray(depth, rows, columns, 0, 9);
PrintArray(array);


int[,,] GetArray(int m, int n, int l, int minValue, int maxValue)
{
    int count = 10;
    int[,,] arr = new int[m, n, l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                arr[i, j, k] = count;
                count++;
            }
        }
    }
    return arr;
}

void PrintArray(int[,,] array)
{
    int page = 0;
    int line = 0;
    int bar = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Page № {i}");
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ");
                page = i;
                line = j;
                bar = k;
                Console.Write($"({page}, {line}, {bar}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("====================================");
    }
}



// Метод заполнения массива рандомными числами

// int[,,] GetArray(int m, int n, int l, int minValue, int maxValue)
// {
//     int[,,] arr = new int[m, n, l];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             for (int k = 0; k < l; k++)
//             {
//                 arr[i, j, k] = new Random().Next(minValue, maxValue + 1);
//             }

//         }

//     }
//     return arr;
// }