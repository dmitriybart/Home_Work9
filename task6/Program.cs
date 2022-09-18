// Написать программу возведения числа А в целую стень B

int PowNumber(int userNumber, int power)
{
    if(power == 0) return 1;
    if(power == 1) return userNumber;
    else
    { 
        int result = userNumber * PowNumber(userNumber, power-1);
        return result;
    }
}

Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите степень числа: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write(PowNumber(m,n));