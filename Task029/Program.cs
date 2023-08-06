// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

//Ввод числа с экрана
int Prompt(string message)
{
    Console.Write(message); //Выводим приглашение к вводу
    string readInput = Console.ReadLine(); //Вводим значение
    int result = int.Parse(readInput); //приводим к числу
    return result; //возвращаем результат
}

//метод для получения случайных значений массива
int[] GenerateArray (int Length, int minValue, int maxValue)
{
    int[] array = new int[Length]; //объявляем массив
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1); //заполняем случайными цифрами из
        //диапазона SatrArr до EndArr
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, "); //вывод значения массива
    }
   Console.Write($"{array[array.Length - 1]}"); //вывод значения массива
   Console.Write("]"); 
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значение для диапазона случайного числа: ");
int[] array = GenerateArray (length, min, max); // заполнение массива случайными числами
PrintArray(array); //вывод массива