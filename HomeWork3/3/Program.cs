// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Первый вариант

int cubeTable(int n)
{
    for (int i = 1; i <= n; i++)
    {
        //int result = i * i * i;
        Console.Write(Math.Pow(i, 3) + " | ");
    }
    return n;
}

Console.Write("Введите число для расчета таблицы: ");
int number = Convert.ToInt32(Console.ReadLine());

cubeTable(number); 

/* Второй вариант

double cube(double n)
{
    double a = Math.Pow(n, 3);
    return a;
}

Console.Write("Введите число для расчета таблицы: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = 1;
while (i <= number) 
{
    Console.Write(cube(i) + " | ");
    i++;
}
*/