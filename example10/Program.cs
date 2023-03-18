// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень в которую будет возведено число: ");
int b = Convert.ToInt32(Console.ReadLine());

int Step (int a, int b)
{
    int ab = 1;
    {
        for (int i=1; i<=b; i++)
        ab = ab*a;
    }
    return ab;
}

Console.WriteLine($"{a} возведенное в степень {b} равно {Step(a,b)}");
