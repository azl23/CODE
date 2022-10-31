﻿// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] matrix = new int[3, 4]
{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4}
};

int n = 4;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

for(int k = 0; k < 3; k++)
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        //     a               b
        if (matrix[k, j] < matrix[k, j + 1])
        {
            int t = matrix[k, j];
            matrix[k, j] = matrix[k, j + 1];
            matrix[k, j + 1] = t;
        }
    }
}

System.Console.WriteLine();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}




// 1, 4, 7, 2
// 4, 7, 2, 1
// 7, 4, 2, 1
// 7, 4, 2, 1

// 1, 2, 3, 4
// 2, 3, 4, 1   /1
// 3, 4, 2, 1   /2
// 4, 3, 2, 1   /3 


