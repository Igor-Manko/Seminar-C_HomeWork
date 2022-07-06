// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введете числа для преобразования в массив: ");
string str = Console.ReadLine();
char[] arr = str.ToCharArray();
Console.WriteLine(str);

/*
int[] fillArray(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    while (index < length)
    {
        arr[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
    return arr;
}


int[] array = new int[8];
fillArray(array);

Console.Write(String.Join(" ", array)); // печать массива сразу
*/