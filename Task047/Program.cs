﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] CreateArrayRndDouble(int rows, int columns)
{
        double [,] matrix = new double[rows, columns];
        Random random = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
                for (int j = 0; j < matrix.GetLength(1); j++) 
                {
                       matrix[i, j] = random.Next(-9, 10)+ random.NextDouble(); 
                }
        }
        return matrix; 
}

void PrintMatrix(double[,] matrix) 
{
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                        Console.Write($"{matrix[i, j]:f2}\t");
                }
                Console.WriteLine(); 
        }
}

double[,] matrix = CreateArrayRndDouble(3, 4); 
PrintMatrix(matrix); 