// Показать натуральные числа от M до N, N и M заданы
void NumberCount(int m, int n)
{
    if (m <= n)
    { 
        Console.Write($"{m} ");
        NumberCount(m+1, n);
    }
    else Console.Write(" ");
}

Console.Write("Введите начало отсчета: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите конечное число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

NumberCount(m, n);
