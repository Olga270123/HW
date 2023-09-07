// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое число N больше 0, но меньше 4: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число M больше 0, но меньше 11: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if(numberM < 0 || numberN < 0) 
{
    Console.WriteLine("Некорректный ввод. Введите натуральное число (больше 0)");
    return;
}

int Akkerman(int numberM, int numberN)
{
    if (numberM == 0)
        return numberN + 1;
    if (numberM > 0 && numberN == 0)
        return Akkerman(numberM - 1, 1);
    else
        return Akkerman(numberM - 1, Akkerman(numberM, numberN - 1));
}

int InputNumber(string message)
{
 Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"A({numberM}, {numberN}) = {Akkerman(numberM, numberN)}");
