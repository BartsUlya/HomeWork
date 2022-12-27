
Console.WriteLine("ВВедите число m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите число n");
int n = int.Parse(Console.ReadLine()!);


int[,] matrix = Create2DArray(m, n, 1, 10);
Print2DArray(matrix);
Console.WriteLine();
PrintArray(ArithmeticalMean(matrix));

void PrintArray (double []array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
double[] ArithmeticalMean (int[,] matrix)
{
double [] result = new double[matrix.GetLength(1)];
for (int j = 0; j < matrix.GetLength(1); j++)
    {
       int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i,j];
        }
        result [j]=Math.Round((double)sum / matrix.GetLength(0),2);
    }
    return result;
}

int[,] Create2DArray(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
