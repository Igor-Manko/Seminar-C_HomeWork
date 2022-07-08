// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] fillArray(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    while (index < length)
    {
        arr[index] = new Random().Next(-50, 50);
        index++;
    }
    return arr;
}

int mySumArray(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    int result = 0;
    while (index < length)
    {
        if (index % 2 != 0) result = result + arr[index];
        index++;
    }
    return result;
}


int[] array = new int[5];
fillArray(array);

Console.WriteLine(String.Join(" ", array));
Console.WriteLine(mySumArray(array));