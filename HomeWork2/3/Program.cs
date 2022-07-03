// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели от 1 до 7 :");
int num = Convert.ToInt32(Console.ReadLine());

string numDay() {

    if (num >= 1 & num <= 7) {
        if ( num >= 1 & num <= 5) {
            return "Сегодня не выходной!";
        }
        else {
            return "Сегодня ВЫХОДНОЙ!";
        }
    } 
    else {
        return "Введите число от 1 до 7 !";
    }
}

Console.WriteLine(numDay());

/*
switch (num)
{
    case 1:{
        Console.WriteLine("Понедельник");
        break;
    }
    case 2:{
        Console.WriteLine("Вторник");
        break;
    }
    case 3:{
        Console.WriteLine("Среда");
        break;
    }
    case 4:{
        Console.WriteLine("Четверг");
        break;
    }
    case 5:{
        Console.WriteLine("Пятница");
        break;
    }
    case 6:{
        Console.WriteLine("Суббота - Выходной");
        break;
    }
    case 7:{
        Console.WriteLine("Воскресенье - Выходной");
        break;
    }
}
*/