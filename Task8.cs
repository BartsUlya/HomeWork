/*Задача8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("введите число");

string input = Console.ReadLine()!;
int parsedinput = int.Parse(input);

/*for (int i = 1; i <= parsedinput ; i++) 
{
    if (i % 2 == 0) 
    {
        Console.WriteLine(i + "четное число");
    }

}*/
int counter = 1;
while (counter <= parsedinput)
{
    if (counter % 2 == 0) 
    {
        Console.WriteLine(counter);
    }
    counter = counter + 1;
}