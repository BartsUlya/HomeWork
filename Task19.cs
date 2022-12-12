/*Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine()!);

if (10000 <= number && number <= 99999)
{
    int digit1 = number / 10000;
    int digit2 = number / 1000 % 10;
    int digit4 = number / 10 % 10;
    int digit5 = number % 10;

    if (digit1 == digit5 && digit2 == digit4)
    {
        Console.WriteLine("Число полиндром");
    }
    else
    {
        Console.WriteLine("Число НЕ полиндром");
    }
}
