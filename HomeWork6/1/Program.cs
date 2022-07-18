// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int ReadArrPositiv()
{
    Console.Write("Введите числа: ");
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int count = 0;

    for (int index = 0; index < arr.Length; index++)
    {
        if (arr[index] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine($"Количество элементов > 0: {ReadArrPositiv()}");