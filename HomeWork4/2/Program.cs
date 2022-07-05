// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

int mySumNumber(int num)
{
    int div = 0;
    int sum = 0;
    while (num > 0)
    {
        div = num % 10;         // 452 % 10 -> 2
        sum = sum + div;        // 0 + 2 = 2
        num = num / 10;         // 452 / 10 = 45
    }
    return sum;
}

Console.Write("Введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма цифр в числе: " + mySumNumber(numbers));
