// Написать программу показывающие первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем


int Fibonacci(int p, int t, int position)
{
    if (position == 1) return p;
    if (position == 2) return t;
    return Fibonacci(p, t, position - 2) + Fibonacci(p, t, position - 1);
}
Console.Write("Введите 1-е число: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите 2-е число: ");
int n = int.Parse(Console.ReadLine() ?? "0");
void PrintNumbers(int count, int newPosition = 0)
{
    newPosition++;
    if(count >= newPosition)
    {
        Console.Write($"{Fibonacci(m, n, newPosition)} ");
        PrintNumbers(count, newPosition);
    }
    else return; 
}

Console.Write("Введите количество чисел в ряду: ");
int k = int.Parse(Console.ReadLine() ?? "0");
PrintNumbers(k);