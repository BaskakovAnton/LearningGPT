using System;
/* Поиск максимального элемента:
Напишите функцию, которая находит и возвращает максимальный элемент в заданном массиве целых чисел. */
int MaxElement(int[] Array)
{
    int length = Array.Length;
    int max = Array[0];
    int i = 1;
    while (i < length)
    {
        if (max < Array[i])
        {
            max = Array[i];
            i++;
        }
        else
        {
            i++;
        }
    }
    return max;
}

int[] Arr = { 99, 12, 31 };
int result = MaxElement(Arr);
Console.WriteLine(result);