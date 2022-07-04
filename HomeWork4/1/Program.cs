// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Exponention(double a, double b)
{
    double result = Math.Pow(a, b);
    return result;
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат возведения числа " + n + " в степень " + m + " = " + Exponention(n, m));

