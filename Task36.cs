Console.WriteLine("Введите размер массива ");
int arrayLenght = int.Parse(Console.ReadLine()!);


int[] array = CreateArray(arrayLenght,1,10);
PrintArray(array);
int oddCount = SumOddPosition(array);
Console.WriteLine(oddCount);



int[] CreateArray (int length, int minValue, int maxValue)
{
    int[] array= new int[length];
    for (int i = 0; i <array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int CountOdd(int[]array)
{
    int counter =0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] %2 ==1)
        counter ++;
    }
    return counter;
}
int SumOddPosition(int[]array)
{
    int sumNumbers = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sumNumbers += array[i];
    }
    return sumNumbers;
}
