// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
Console.WriteLine("введите первое число");

string input1 = Console.ReadLine();
int parsedinput1 = int.Parse(input1);

Console.WriteLine("введите второе число ");
string input2 = Console.ReadLine();
int parsedinput2 = int.Parse(input2);


if (parsedinput1 > parsedinput2)

{
    Console.WriteLine("max = " + parsedinput1);
    Console.WriteLine("min = " + parsedinput2);
}
else if (parsedinput2 > parsedinput1)
{
    Console.WriteLine("max = " + parsedinput2);
    Console.WriteLine("min = " + parsedinput1);
}
else
{
    Console.WriteLine("Числа равны");
}
