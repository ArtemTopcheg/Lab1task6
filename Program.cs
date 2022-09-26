//Задача 6 S=sqrt(p(p-a)(p-b)(p-c))

int a, b, c;
Console.WriteLine(" Введите длины сторон треугольника:");
string A1 = Console.ReadLine();
a = Convert.ToInt32(A1);
string B1 = Console.ReadLine();
b = Convert.ToInt32(B1);
string C1 = Console.ReadLine();
c = Convert.ToInt32(C1);
if ((a + b > c || a + c > b || b + c > a) && (a != b && b != c && a != c))
{
    int p = a + b + c;
    double result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    Console.WriteLine("Площадь треугольника равна = " + result);
}
else
{
    Console.WriteLine("Введите корректные значения длин сторон");
}