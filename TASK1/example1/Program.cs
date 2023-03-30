// Напишите программу, которая получает на входе случайное число и удаляет вторую цифру этого числа.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = Convert.ToInt32(Math.Truncate(Math.Log10(number)));
int count2 = 1;
int i = count;
if (count < 1) { Console.WriteLine($" В числе {number} нет второго разряда "); }

else
{
    while (i > 0)
    {
        count2 = count2 * 10;
        i = i - 1;
    }

    int newnumber1 = number / count2;
    int newnumber2 = number % (count2 / 10);
    if (count == 1) { Console.WriteLine($"Новое число {newnumber1} "); }
    else
        if (newnumber2 == 0) { Console.WriteLine($"Новое число {newnumber1}{0} "); }

    else
        if (newnumber2 < count2 / 100) { Console.WriteLine($"Новое число {newnumber1}{0}{newnumber2} "); }
    else Console.WriteLine($"Новое число {newnumber1}{newnumber2} ");
}