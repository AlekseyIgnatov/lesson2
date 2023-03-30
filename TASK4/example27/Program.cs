// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum (int n)
{
    int summ = 0;
    int n2 = n;
    while (n2 > 0)
    {
       summ = summ + n2 %10;
       n2/=10;
    }
    return summ;
}



Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в веденом числе равна {Sum(n)}");