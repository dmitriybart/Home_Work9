// Написать программу вычисления функции Аккермана
int AckermannFunc(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m > 0) && (n == 0))
      return AckermannFunc(m - 1, 1);
    else
      return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
}
Console.Write("Введите 1-е число: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите 2-е число: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write(AckermannFunc(m, n));