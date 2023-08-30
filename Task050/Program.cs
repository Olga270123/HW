// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

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

void PositionsInArray(int[,] matrix, int row, int column)
{
    if (row < matrix.GetLength(0) && column < matrix.GetLength(1))
    {
        Console.Write($"[{row}, {column}] такая позиция есть: {matrix[row, column]}");
    }
    else
    {
        Console.WriteLine($"[{row}, {column}] такой позиции в массиве нет");
    }
}


int[,] array2d = CreateMatrixRndInt(5, 6, 0, 100);
PrintMatrix(array2d);
Console.WriteLine();
Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());
PositionsInArray(array2d, row, column);