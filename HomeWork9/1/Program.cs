// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


void SeriesNumbers()
{
    Console.Write("Введите начальное число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конечное число: ");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a < b)
    {
        for (int count = a; count <= b; count++)
        {
            Console.Write($"{a++} ");
        }
    }
    else Console.WriteLine("Начальное число должно быть меньше конечного!");
}

SeriesNumbers();