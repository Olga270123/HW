// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число 1: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число 2: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 1 || numberN < 1)
{
    Console.WriteLine("Это не натуральное число. Введите натуральное число (больше 0)");
    return;
}

int SumNumbers(int numberM, int numberN)
{
    if (numberM == numberN) 
    {
        return numberN;
    }  
    else if (numberM < numberN)
    {
        return numberN + SumNumbers(numberM, numberN - 1);
    }
    else 
    {
        return numberN + SumNumbers(numberM, numberN + 1);
    }
}

Console.Write($"\nM = {numberM}; N = {numberN} - >");
Console.Write(SumNumbers(numberM, numberN));

