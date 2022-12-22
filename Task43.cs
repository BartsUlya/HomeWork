Console.WriteLine("Введите b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2");
double k2 = double.Parse(Console.ReadLine()!);



if (k1 != k2)
{
    double[] intersectPoint = FindIntersectPoint(b1, b2, k1, k2);
    Console.WriteLine(intersectPoint[0]);
    Console.WriteLine(intersectPoint[1]);
}
else Console.WriteLine("Прямые не пересекаются");


double[] FindIntersectPoint(double b1, double b2, double k1, double k2)
{
    double[] result = new double[2];
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    result[0] = x;
    result[1] = y;
    return result;
}
