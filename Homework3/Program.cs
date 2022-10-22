// Homework 3
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*

void NumberPoli (int number)
{
if (number > 9999 && number < 100000)
{
    int fNumber = number % 10; 
    int vNumber = number / 10000; 

    if (fNumber == vNumber)

    {
        int wNumber = number - fNumber * 10000;
        int result = (wNumber - fNumber) / 10;

        int oNumber = result % 10; 
        int mNumber = result / 100;
        if (mNumber == oNumber) Console.WriteLine ("Полиндром");

    }
    else Console.WriteLine ("Число не является полиндромом");

}
else Console.WriteLine ("Ошибка. Вы ввели не пятизначное число");
}

Console.Write ("Введите пятизначное число: ");
int result1 = Convert.ToInt32(Console.ReadLine());

NumberPoli(result1);
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double Distance (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double catet1 = x1 - x2;
    double catet2 = y1 - y2;
    double catet3 = z1 - z2;
    double length = Math.Sqrt((catet1 * catet1) + (catet2 * catet2) + (catet3 * catet3));
    return length;
}

Console.Write ("Координата Х1: ");
double result1 = Convert.ToDouble(Console.ReadLine());
Console.Write ("Координата Y1: ");
double result2 = Convert.ToDouble(Console.ReadLine());
Console.Write ("Координата Z1: ");
double result3 = Convert.ToDouble(Console.ReadLine());
Console.Write ("Координата X2: ");
double result4 = Convert.ToDouble(Console.ReadLine());
Console.Write ("Координата Y2: ");
double result5 = Convert.ToDouble(Console.ReadLine());
Console.Write ("Координата Z2: ");
double result6 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ($"Ответ: {Distance (result1, result2, result3, result4, result5, result6)}");

*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*

void NumberCube (int number)
{
    int index = 1;
    while (index <= number)
    {
        double result = Math.Pow(index,3);
        Console.Write(result + " ");
        index++;
    }
}

Console.Write("Введите число: ");
int res = Convert.ToInt32(Console.ReadLine());
NumberCube(res);

*/