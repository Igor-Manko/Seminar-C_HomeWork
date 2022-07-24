// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            //arr[i,j] = new Random().Next(1,10);
            Console.Write($" {arr[i, j] = new Random().Next(1, 9)}");
        }
        Console.WriteLine();
    }
}

void MinSumLineArray(int[,] arr)
{
    int indexLine = 0;
    int minsum = Int32.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            indexLine++;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в {indexLine} строке");
}

int[,] array = new int[3, 3];
FillArray(array);
MinSumLineArray(array);
