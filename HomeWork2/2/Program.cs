// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int num = new Random().Next(10, 999);
Console.WriteLine("Введите число:");
string numbers = Console.ReadLine();   // прям здесь считываем цифры со ввода

string thirdNumber () {

    if (numbers.Length <= 2) {          // если длина символов в строке меньше 2
        return "В числе нет третьей цифры!";
    }
    else {
        return "Третья цифра в числе " + numbers+ " : " + numbers[2];  // выведи символ с индексом 2
    }
}

Console.WriteLine(thirdNumber());