// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void SumSeriesNumbers()
{
    Console.Write("Введите начальное число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конечное число: ");
    int b = Convert.ToInt32(Console.ReadLine());

    int sum = 0;
    if (a < b)
    {
        for (int count = a; count <= b; count++)
        {
            sum += +count;
        }
    }
    else {
        for (int count = b; count <= a; count++)
        {
            sum += +count;
        }
    }
     Console.Write($"Сумма числе между начальным и конечным: {sum}");
}

SumSeriesNumbers();