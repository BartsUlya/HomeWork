Console.WriteLine("ВВедите число m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите число n");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите позицию i");
int index1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите позицию j");
int index2 = int.Parse(Console.ReadLine()!);


int[,] matrix = Create2DArray(m, n, 1, 10);
Print2DArray(matrix);
Console.WriteLine();

 if (index1>m && index2>n)
 Console.WriteLine("такого числа нет");
 else
 {
 int element = matrix[index1,index2];
 Console.WriteLine(element);
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
