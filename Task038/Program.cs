// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
   
    return arr;
}

void PrintArrayDouble(double[] arr, int round = 1)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        double roundNum = Math.Round(arr[i], 1);  // округление
        if (i < arr.Length - 1) Console.Write($"{roundNum}, ");
        else Console.Write($"{roundNum}"); 
    } 
    Console.Write("]");
}

double Difference(double[] randomArray)
{
double min = randomArray[0];
double max = randomArray[0];
int i = 1;
while (i < randomArray.Length)
{
if (max<randomArray[i])
max = randomArray[i];
if (min>randomArray[i])
min = randomArray[i];
i = i + 1;
}
return max-min;
}

double[] array = CreateArrayRndDouble(5, 0, 100);
PrintArrayDouble(array);
Console.WriteLine();

Difference(array);
Console.Write($"Разница между максимальным и минимальным элементов массива: {Difference(array):F1}");