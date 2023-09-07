// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

void Create3DArray(int[,,] array3D, int[] uniqValueArray)
{
    int count = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = uniqValueArray[count];
                count++;
            }
        }
    }
}

void PrintMatrix3D(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[j, k, i]}({j},{k},{i}) ");
            }
        }
    }
}

void CreateUniqArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int num = new Random().Next(10, 100);
        if (UniqValueInArray(array, num, i) == true)
        {
            array[i] = num;
        }
        else
        {
            i--;
        }
    }
}

bool UniqValueInArray(int[] array, int num, int index)
{
    bool result = true;
    for (int i = 0; i <= index; i++)
    {
        if (array[i] == num)
        {
            result = false;
            break;
        }
    }
    return result;
}

int[,,] array3D = new int[2, 2, 2];
int[] uniqArray = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
CreateUniqArray(uniqArray);
Create3DArray(array3D, uniqArray);
PrintMatrix3D(array3D);
