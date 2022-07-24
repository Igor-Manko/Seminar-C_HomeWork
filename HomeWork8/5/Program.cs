// Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j] = new Random().Next(1, 21)} ");
//         }
//         Console.WriteLine();
//     }
// }

void SpiralSort(int[,] arr)
{
    int num = 1;
    int i = 0;
    int j = 0;
    while (num <= arr.GetLength(0) * arr.GetLength(1))
    {
        arr[i, j] = num;
        if (i <= j + 1 && i + j < arr.GetLength(0) - 1)
            ++j;
        else if (i < j && i + j >= arr.GetLength(1) - 1)
            ++i;
        else if (i >= j && i + j > arr.GetLength(0) - 1)
            --j;
        else
            --i;
        ++num;
    }
}

void PrintSortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
                Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }

}

int[,] array = new int[4, 4];
// FillArray(array);
// Console.WriteLine();
SpiralSort(array);
PrintSortArray(array);

