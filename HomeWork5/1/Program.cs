// Задайте массив заполненный случайными положительными трёхзначными числами. 

// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] fillArray(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    while (index < length)
    {
        arr[index] = new Random().Next(100, 1000);
        index++;
    }
    return arr;
}

int myEven(int[] arr)
{
    int count = 0;
    int index = 0;
    int length = arr.Length;

    while (index < length)
    {
        if (arr[index] % 2 == 0) count++;       // проверка четности элемента массива 
        index++;
    }
    return count;
}


int[] array = new int[4];
fillArray(array);

Console.WriteLine(String.Join(" ", array));        // функция печати массива
Console.Write("Количество четных чисел в массиве: " + myEven(array));
