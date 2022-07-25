// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int AkkermanFunction(int a, int b)
{
    if (a == 0) return b + 1;
    else if (b == 0) return AkkermanFunction(a - 1, 1);
    else return AkkermanFunction(a - 1, AkkermanFunction(a, b - 1));
}

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int functionAkkerman = AkkermanFunction(m, n);
Console.Write($"Функция Аккермана = {functionAkkerman} ");