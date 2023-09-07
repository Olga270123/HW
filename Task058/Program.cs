// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 3, 4
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
   
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5}"); //форматирование вывода
        }
        Console.WriteLine("|");
    } 
}

int[,] MultiplicationTwoMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] matrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
           for (int k = 0; k < matrixOne.GetLength(1); k++)
           {
                matrix[i, j] += matrixOne[i, k] * matrixTwo[k, j];
           }
        }
    }
    return matrix;
}

int[,] matrixOne = CreateMatrixRndInt(2, 3, 1, 10);
PrintMatrix(matrixOne);
Console.WriteLine();

int[,] matrixTwo = CreateMatrixRndInt(3, 2, 1, 10);
PrintMatrix(matrixTwo);
Console.WriteLine();
PrintMatrix(MultiplicationTwoMatrix(matrixOne, matrixTwo));

