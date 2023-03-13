// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.WriteLine($"Четные числа от 1 до {number} ");
while (i<=number)
    {
        int num = i%2;
        if (num == 0) { Console.Write(i+ " ");}
        i++;
    }
