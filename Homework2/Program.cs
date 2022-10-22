// Домашнее задание 2.
// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int CutDigit (int fNumber)
{
    int ed = fNumber % 10;
    int n = fNumber / 100;

    int result = (fNumber - n*100) / 10;
    return result;
}

Console.Write ("Введите трехзначное число: ");
int number = Convert.ToInt32 (Console.ReadLine());

int res = CutDigit(number);
Console.Write ($"Вторая цифра этого числа: {res}");
*/

// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*

int ThirdDigit (int number)
{
    while (number > 999)
    {
        number = number / 10;
    }
    if (number > 99 || number < 1000)
    {
        number = number % 10;
    }
    return number;
}
Console.Write ("Введите число: ");
int n = Convert.ToInt32 (Console.ReadLine());

if (n < 100)
    {
        Console.Write ("Отсутствует третья цифра");
    }
else 
{
int res = ThirdDigit(n);
Console.Write ($"Третья цифра этого числа: {res}");
}

*/

// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*

Console.Write ("Введите день недели (от 1 до 7): ");
int number = Convert.ToInt32 (Console.ReadLine());

    if (number == 6 || number == 7)
    {
        Console.Write ("Является выходным днем");
    }
    else 
    {
        if (number < 1 || number > 7)
        {
            Console.Write ("Ошибка! Вы ввели неккоректную цифру. Начните заново");
        }
        else
        {
            Console.Write ("Является рабочим днем");
        }

    }

*/