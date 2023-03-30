// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2) { Console.WriteLine($" {number1} больше {number2} "); }
else
   if (number2 > number1) { Console.WriteLine($" {number2} больше {number1} "); }
else Console.WriteLine($" {number1} равно {number2} ");