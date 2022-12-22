Console.WriteLine("Введите несколько чисел");
int numbers = int.Parse(Console.ReadLine()!);


Console.WriteLine(CountPositiveNumbers(numbers));

int CountPositiveNumbers(int numbers)
{
    int counter = 0;
    for (int i = 0; i < numbers; i++)
    {
        int currentNumber = int.Parse(Console.ReadLine()!);
        if (currentNumber>0)
        {
            counter++;
        }

    }
    return counter;
}
