//Задача 27: Напишите программу, которая принимает
//  на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Ограничения:
// - Должна быть отдельная функция, которая возвразает результат суммы цифр
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.WriteLine("Введите число");
int num = Math.Abs(int.Parse(Console.ReadLine()!));

int digitFunction = Sumdigit(num);
Console.WriteLine(digitFunction);

int Sumdigit(int number)
{
    int sum = 0;
    while (number >= 10)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum + number;
}
