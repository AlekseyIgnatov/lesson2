// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int num = number % 2;
if (num == 0){Console.WriteLine($" Введеное число четное ");}
    else Console.WriteLine($" Введеное число нечетное ");