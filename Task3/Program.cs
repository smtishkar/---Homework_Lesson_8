// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



Console.Clear();
int columns1 = 4;
int rows1 = 2;
int columns2 = 2;
int rows2 = 5;

int[,] firstMatrix = GetArray(rows1, columns1, 1, 4);
int[,] secondMatrix = GetArray(rows2, columns2, 1, 4);
PrintArray(firstMatrix);
Console.WriteLine();
PrintArray(secondMatrix);
Console.WriteLine();
int[,] thirddMatrix = MatrixProduction(firstMatrix, secondMatrix);
Console.WriteLine();
PrintArray(thirddMatrix);



int[,] MatrixProduction(int[,] array1, int[,] array2)
{
    int[,] arr = new int[rows2, columns1];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array2.GetLength(0); k++)
                {
                    // Console.Write(arr[i, j]);               
                    arr[i, j] += array1[i, k] * array2[k, j];

                    Console.Write($"{array1[i, k]} ");
                    // // Console.Write ($"{array1[i,k+1]} ");
                    Console.Write($"{array2[k, j]} ");
                    // Console.Write ($"{array2[k,j+1]} ");
                    Console.WriteLine();
                    // Console.WriteLine (arr[i,j]);
                }
                Console.WriteLine();
            }
        }
        
    }
    else Console.WriteLine("Матрицы нельзя перемножить");
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



// int [,] MatrixProduction (int [,] array1, int [,] array2)
// {
//     int [,] arr = new int [rows1, columns2]; 
//     for (int i = 0; i < columns2; i++)
//     {
//         for (int j = 0; j < rows1; j++)
//         {

//             arr[i, j] = array1[i,j] * array2[j,i] + array1[i+1,j] * array2[j, i+1];
//             Console.Write ($"{array1[i,j]} ");
//             Console.Write ($"{array1[i+1,j]} ");
//             Console.Write ($"{array2[j,i]} ");
//             Console.WriteLine ($"{array2[j, i+1]} ");
//             // Console.Write ($"{array2[i,j]} ");
//             // Console.WriteLine ($"{array2[i, j+1]} ");

//             Console.WriteLine (arr[i,j]);
//         }

//     }
//     return arr;
// }