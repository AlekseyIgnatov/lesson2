// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, 
// является ли оно палиндромом. Через строку нельзя решать само собой.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int digitnumber = Convert.ToInt32(Math.Truncate(Math.Log10(number)));
int count = Convert.ToInt32(Math.Pow (10, digitnumber));
int [] numarr = new int[digitnumber+1];
int num;
int num1 = number;
int x1 = numarr.Length-1;
int flag = 0;
int stop = numarr.Length/2;

for (int i=0; i < numarr.Length; i++)
    {
        num = num1/count;
        num1 = num1 % count;
        numarr[i] = num;
        count = count / 10;
    }


for (int i=0; i < stop; i++)
{
    if (numarr[i] == numarr[x1])
    {
        x1 = x1 - 1;
        flag = flag + 1;
    }
    else
    {
        flag = 0;
    }     
}
if (flag == 0) {Console.WriteLine($"Введеное число {number} не является палиндромом");}
else Console.WriteLine($"Введеное число {number} палиндром");
 