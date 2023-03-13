// Напишите программу, которая принимает на вход целое число любой разрядности 
// и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. 
// Через строку решать нельзя.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = Convert.ToInt32(Math.Truncate(Math.Log10(number)));
int count2 = 1;
int i = count-1;
if (count < 1) { Console.WriteLine($" В числе {number} нет второго разряда "); }

else
{
    while (i > 0)
    {
        count2 = count2 * 10;
        i = i - 1;
    }

    int newnumber = (number / count2) %10;
    // int newnumber2 = newnumber1 % 10;
    
    if (newnumber == 0) { Console.WriteLine($" Вторая цифра в числе {0} "); }
    else Console.WriteLine($" Вторая цифра в числе {newnumber} ");
 
 };