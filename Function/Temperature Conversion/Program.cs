/* Конвертация температуры:
Напишите функцию, которая принимает температуру в градусах Цельсия и конвертирует ее в градусы Фаренгейта (или наоборот) согласно формуле конвертации. */
double TemperatureConversion(double arg1)
{
    double result = ((arg1 * 9) / 5) + 32;
    return result;
}

System.Console.Write("Введите колличество градусов: ");
double num = double.Parse(Console.ReadLine());
double Temp = TemperatureConversion(num);
string formattedTemp = Temp.ToString("F1");
Console.WriteLine($"{num} градусов Цельсия равны {Temp} градусам Фаренгейта");
