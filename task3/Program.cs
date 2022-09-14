// Найти сумму элементов от M до N, N и M заданы

int SumNumber(int m, int n)
{
    if(m == n+1) return 0;
    else
    { 
        int sum = m + SumNumber(m+1, n);
        return sum;
    }
}

Console.Write("Введите 1-е число: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите 2-е число: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write(SumNumber(m,n));

