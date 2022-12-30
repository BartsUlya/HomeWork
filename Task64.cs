Console.WriteLine("Введите число N"); 
int n = int.Parse(Console.ReadLine()!); 


Console.Write(RecursionN(n));  
string RecursionN(int n)
{

if (n== 1)
{
return n.ToString();
}
else
{
return n.ToString() + ", " + RecursionN(n - 1);
}
}
