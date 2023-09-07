// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int SumRows(int[,] matrix, int i)
{
  int sum = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sum += matrix[i,j];
  }
  return sum;
}

void MinResult (int[,] matrix)
{
int minSumRows = 0;
int sumElem = SumRows(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSumElem = SumRows(matrix, i);
  if (sumElem > tempSumElem)
  {
    sumElem = tempSumElem;
    minSumRows = i;
  }
}
Console.WriteLine($"Строкa {minSumRows+1} с наименьшей суммой элементов. Сумма {minSumRows+1} строки = {sumElem}.");
}

int[,] array2d = CreateMatrixRndInt(5, 3, 0, 10);
PrintMatrix(array2d);

Console.WriteLine();
MinResult (array2d);

