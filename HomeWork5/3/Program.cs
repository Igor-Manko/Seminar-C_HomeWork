// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] fillArray(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    while (index < length)
    {
        arr[index] = new Random().Next(0, 100);
        index++;
    }
    return arr;
}

int findMax(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    int max = 0;
    while (index < length)
    {
        if (arr[index] > max) max = arr[index];
        index++;
    }
    return max;
}


int findMin(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    int min = findMax(arr);
    while (index < length)
    {
        if (arr[index] < min) min = arr[index];
        index++;
    }
    return min;
}

int[] array = new int[4];
fillArray(array);

Console.WriteLine(String.Join(" ", array)); //печать самого массива

Console.WriteLine("Максимальное число в массиве: " + findMax(array));
Console.WriteLine("Минимальное число в массиве: " + findMin(array));
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: " + (findMax(array) - findMin(array)));