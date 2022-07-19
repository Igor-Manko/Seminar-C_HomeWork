// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

void RandomMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j] = new Random().Next(-9, 10)} ");
        }
        Console.WriteLine();
    }
}

void FindNumber(int[,] matr)
{
    Console.Write("Введите строку элемента для поиска: ");
    int find1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите столбец элемента для поиска: ");
    int find2 = Convert.ToInt32(Console.ReadLine());

    if (find1 <= matr.GetLength(0) | find2 <= matr.GetLength(1))
    {
        Console.WriteLine($"Элемент на данной позиции в массиве: {matr[find1 - 1, find2 - 1]}");
    }
    else Console.WriteLine("Позиция отсутствует в массиве!");
}

int[,] matrix = new int[3, 4];
Console.WriteLine("Текущий массив: ");
RandomMatrix(matrix);

FindNumber(matrix);
