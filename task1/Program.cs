// Показать натуральные числа от N до 1, N задано

void NumberCount( int n)
{
    if (1 <= n)
    { 
        Console.Write($"{n} ");
        NumberCount(n-1);
    }
    else Console.Write(" ");
}


Console.Write("Введите конечное число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

NumberCount(n);