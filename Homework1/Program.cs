// Howemork 1

// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*

Console.WriteLine ("Write a first number: ");
int FirstNumber = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Write a second number: ");
int SecondNumber = Convert.ToInt32 (Console.ReadLine());

if (FirstNumber < SecondNumber)
{
    Console.WriteLine("Result: ");
    Console.WriteLine($"max = {SecondNumber}, min = {FirstNumber}");
}
else
{
    Console.WriteLine("Result: ");
    Console.WriteLine ($"max = {FirstNumber}, min = {SecondNumber}");
}
*/

// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*

Console.WriteLine ("Write a first number: ");
int FirstNumber = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Write a second number: ");
int SecondNumber = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Write a second number: ");
int ThurdNumber = Convert.ToInt32 (Console.ReadLine());

if (FirstNumber > SecondNumber)
{
    if (FirstNumber > ThurdNumber)
    {
     Console.WriteLine($"Result: max = {FirstNumber}");
    }
    else 
    {
        Console.WriteLine($"Result: max = {ThurdNumber}"); 
    }
}
else
{
if (SecondNumber > ThurdNumber)
{
   if (SecondNumber > FirstNumber) 
   {
    Console.WriteLine($"Result: max = {SecondNumber}");
   }
   else
   {
    Console.WriteLine($"Result: max = {FirstNumber}"); 
   }
}
else
{
   Console.WriteLine($"Result: max = {ThurdNumber}");  
}
}
*/

// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*

Console.WriteLine ("Write a number: ");
int number = Convert.ToInt32 (Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine ($"четное");
}
    else
    {
        Console.WriteLine ($"нечетное");
    }

*/

// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1
/*

Console.Write ("Input a number from 1: ");
int evenNumber = 2;
int number = Convert.ToInt32(Console.ReadLine());

while (evenNumber < number + 1)
{
    Console.Write ($"{evenNumber} ");
    evenNumber = evenNumber + 2;
}

*/

