/* Наибольший общий делитель (НОД):
Напишите функцию, которая принимает два целых числа в качестве параметров и возвращает их наибольший общий делитель (НОД). */
int FindGCD(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

System.Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число: ");
int number2 = int.Parse(Console.ReadLine());
int gcd = FindGCD(number1, number2);
Console.WriteLine($"НОД чисел {number1} и {number2} равен {gcd}");