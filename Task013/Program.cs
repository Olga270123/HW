// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Promt(string message)
{
    Console.Write(message); 
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdRang(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValidateWeekDay(int number)
{
    if (number < 100)
    {
        Console.WriteLine ("Третьей цифры нет");
        return false;
    }
    return true;
}

int number = Promt("Введите число:  ");
if (ValidateWeekDay(number))
{
    Console.WriteLine(GetThirdRang(number));        
}



















// Console.WriteLine("введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number < 0) 
// {
//     number *= -1;
// }

// if(number >= 100)  
// {
//     int result = number /100 % 10;
//     Console.WriteLine($"Третья цифра числа: {result}");
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }