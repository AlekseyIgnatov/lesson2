// Напишите программу, которая принимает на вход число (целое, вещественное, в экспоненциальной форме) и выдаёт сумму цифр в числе.

int SumInt (int n)
{
    int summ = 0;
    //int n2 = n;
    while (n > 0)
    {
       summ = summ + n %10;
       n/=10;
    }
    return summ;
}



Console.Write("Введите число: ");
string n = Console.ReadLine();
int n1;
double n2;

if (n.IndexOf("e") != -1) 
    {
        int numch = n.IndexOf('e'); 
        Console.WriteLine(numch);
        n1 = Convert.ToInt32(n.Remove(numch));
        Console.WriteLine($"Сумма цифр в веденом числе равна {SumInt(n1)}");
    }
    else 
    if (n.IndexOf(",") != -1)
    {
        n2 = Convert.ToDouble(n);
       while (Convert.ToInt32(n2)>0)
        {
            n2=n2%10;
            Console.WriteLine($"Сумма цифр в веденом числе равна {n2}");
            //n1 = Convert.ToInt32(n2%10);
            //Console.WriteLine($"Сумма цифр в веденом числе равна {n1}");
        }
        n1 = Convert.ToInt32(n2);
        //n1 = Convert.ToInt32(n2);
        Console.WriteLine($"Сумма цифр в веденом числе равна {n1}");
        //n1 = Convert.ToInt32(n2);
        //Console.WriteLine($"Сумма цифр в веденом числе равна {SumInt(n1)}");
    }        
    else 
    
    {
        n1 = Convert.ToInt32(n);
        Console.WriteLine($"Сумма цифр в веденом числе равна {SumInt(n1)}");
    }


