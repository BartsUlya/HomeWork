/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console.WriteLine("введите число");

string input1 = Console.ReadLine();
int parsedinput1 = int.Parse(input1);

if(parsedinput1 % 2 == 0)
{
    Console.WriteLine("число четное");
}
else
{
    Console.WriteLine("число нечетное");
}
