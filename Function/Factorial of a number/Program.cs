/* Факториал числа:
Напишите функцию, которая принимает целое положительное число в качестве параметра и возвращает его факториал (произведение всех целых чисел от 1 до этого числа). */
int Factorial(int arg1)
{
    int result = 1;
    int i = 1;
    while (i<= arg1)
    {
        result = result * i;
        i++;
    }
    return result;
}

System.Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

int fac = Factorial(a);
System.Console.WriteLine(fac);
