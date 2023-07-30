// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Promt(string message)
{
    Console.Write(message); 
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int weekDay)
{
    if (weekDay >= 6)
    {
        return true;
    }
    return false;
}

bool ValidateWeekDay(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine ("Это не день недели");
    return false;
}

int weekDay = Promt("Введите день недели:  ");
if (ValidateWeekDay(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Выходной день");        
    }
    else
    {
        Console.WriteLine("Рабочий день");   
    }
}





