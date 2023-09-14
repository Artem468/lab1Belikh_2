// S = t ** 3 - 3 * (t ** 2) + 2
// тогда ↓
// V = 3 * t ** 2 - 6 * t 

Console.Write("Введите t: ");
double t = Convert.ToDouble(Console.ReadLine());
double V = 3 *  Math.Pow(t, 2) - 6 * t;
Console.WriteLine($"V = {V:F2}");