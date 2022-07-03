// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// (одинаковое в обе стороны)

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
string numbers = Console.ReadLine();

string compare()
{
    if (numbers.Length == 5)
    {
        if (numbers[0] == numbers[4] && numbers[1] == numbers[3])
        {
            return "Введенное число палиндром!";
        }
        else
        {
            return "Введенное число НЕ палиндром!";
        }
    }
    else
    {
        return "Введите пятизначное число!";
    }
}

Console.WriteLine(compare());