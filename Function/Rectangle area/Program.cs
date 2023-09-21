/* Площадь прямоугольника:
Напишите функцию, которая принимает ширину и высоту прямоугольника в качестве параметров и возвращает его площадь. */

int RectangleArea(int arg1, int arg2)
{
    int result = arg1 * arg2;
    return result;
}

System.Console.WriteLine("Введите длину первой стороны: ");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите длину второй стороны: ");
int b = int.Parse(Console.ReadLine());

int RecArea = RectangleArea(a, b);
System.Console.WriteLine($"Площадь прямоугольника равна = {RecArea}");