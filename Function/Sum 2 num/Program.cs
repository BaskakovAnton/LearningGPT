/* Сумма двух чисел:
Напишите функцию, которая принимает два целых числа в качестве параметров и возвращает их сумму. */

/* using System;
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//              0   1  2    3  4  5  6    7  8
int[] array = {12, 211, 31, 41, 5, 6, 17, 18, 9};


int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]));

System.Console.WriteLine(max); */

int Sum(int arg1, int arg2)
{
    int result = arg1 + arg2;
    return result;
}

int a = 5;
int b = 6;
int Summa = Sum(a,b);
System.Console.WriteLine(Summa);
