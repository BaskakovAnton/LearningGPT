using System;
/* Среднее значение чисел:
Напишите функцию, которая принимает массив чисел и возвращает среднее значение этих чисел. */
double AVN(int[] Array)
{
    int length = Array.Length;
    if (length==0)
    {
        throw new Exception("Массив пуст.");
    }
       
    Console.WriteLine(length);
    int sum = 0;
    int i = 0;
    while (i < length)
    {
        sum = sum + Array[i];
        i++;
        Console.WriteLine(sum);
    }
    double sre = (double)sum / length;
    return sre;

}
int[] Arr = {1,2,3,6,5,4,6,8,7,9};
double result = AVN(Arr);
Console.WriteLine(result);