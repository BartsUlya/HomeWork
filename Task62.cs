
Console.WriteLine("Введите размерности массива");

int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);

int[,] a = new int[5, 5];
Print2DArray(a);
Console.WriteLine();
Spiral(a);
Print2DArray(a);

void Spiral(int[,] a)///подходит для квадратного
{
    int num = 1;
    for (int vrbl = 0; vrbl < n - 2; vrbl++)
    {
        for (int i = 0 + vrbl; i < m - vrbl; i++)
        {
            a[0 + vrbl, i] = num;
            num++;

        }
        num--;
        for (int j = 0 + vrbl; j < n - vrbl; j++)
        {
            a[j, 4 - vrbl] = num;
            num++;
        }
        num--;
        for (int i = m - 1 - vrbl; i >= 0 + vrbl; i--)
        {
            a[4 - vrbl, i] = num;
            num++;
        }
        num--;
        for (int j = n - 1 - vrbl; j >= 1 + vrbl; j--)
        {
            a[j, 0 + vrbl] = num;
            num++;
        }

    }


}

void Print2DArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write(a[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine(a);
