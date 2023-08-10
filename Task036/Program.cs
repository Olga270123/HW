// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    } 
    Console.Write("]");
}

int SumEvenIndex(int[] arr)
{
    int i = 1;
    int sum = 0;
    while(i < arr.Length)
    {
        sum = sum + arr[i];
        i = i + 2; 
    }   
    return sum;
}

int[] array = CreateArrayRndInt(4, -50, 100);
PrintArray(array);

int result = SumEvenIndex(array);
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечетных позициях -> {result}");
Console.WriteLine();


