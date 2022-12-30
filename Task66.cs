Console.WriteLine("Введите число N"); 
int n = int.Parse(Console.ReadLine()!); 
int m = int.Parse(Console.ReadLine()!); 

Console.Write(SumRecursion(n,m));  
int SumRecursion(int n, int m)
{

if (m== n)
{
return n;
}
else
{

return n + SumRecursion(n+1,m);
}
}
