//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//Например, заданы 2 массива:
//      1 4 7 2      1 5 8 5
//      5 9 2 3      4 9 4 2
//      8 4 2 4      7 2 2 6
//      5 2 6 7      2 3 4 7

//Их произведение будет равно следующему массиву:
//      1   20  56  10
//      20  81   8   6
//      56   8   4  24
//      10   6  24  49

void FillArrayOne(int[,] arr)
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

void FillArrayTwo(int[,] arr)
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

void MultiplexerArray(int[,] arr1, int[,] arr2, int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                newArray[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array1 = new int[3, 3];
int[,] array2 = new int[3, 3];
int[,] resultArray = new int[3, 3];
Console.WriteLine("Вывод первой матрицы:");
FillArrayOne(array1);
//Console.WriteLine();
Console.WriteLine("Вывод второй матрицы:");
FillArrayTwo(array2);
Console.WriteLine("Произведение матриц:");
MultiplexerArray(array1, array2, resultArray);
PrintArray(resultArray);
