// Найти сумму цифр числа
int DivNumber(int number)
{
    if(number == 0) return 0;
    else return number % 10 + DivNumber(number / 10); 
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(DivNumber(number));
