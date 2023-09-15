// Высокий уровень

Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите c: ");
double c = Convert.ToDouble(Console.ReadLine());

double numeratorL = Math.Sqrt(Math.Exp(4) - Math.Pow(Math.Cos(Math.Pow(x, 2) * Math.Pow(a, 5)), 4)) + Math.Pow(Math.Atan(a - Math.Pow(x, 5)), 4);
double denominatorL = Math.E * Math.Sqrt(Math.Abs(a + x * Math.Pow(c, 4)));

double L = numeratorL / denominatorL;
Console.WriteLine($"L = {L:F2}");