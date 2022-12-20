Console.WriteLine("Введите размер массива ");
int arrayLenght = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное число массива");
int minValue = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное число массива");
int maxValue = int.Parse(Console.ReadLine()!);


double[] array = FractionalArray(arrayLenght,minValue,maxValue);
PrintFractionalArray(array);
double counts =DiffMaxMinElement(array);
Console.WriteLine(" Число " + counts);



double[] FractionalArray(int length, int minValue, int maxValue)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] =Math.Round((new Random().NextDouble() *(maxValue - minValue) + minValue),2);
    }
    return array;
}

double DiffMaxMinElement(double[] array) 
{
     double minElement =maxValue;
     double maxElement = minValue;
    for (int i = 0; i < array.Length; i++)
    {
        if(minElement > array[i])
        {
            minElement = array[i];
        }
         if(maxElement < array[i])
        {
            maxElement = array[i];
        }
    }
    Console.WriteLine($"{minElement} и {maxElement}");
    return maxElement - minElement;
}
