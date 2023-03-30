// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
var dayweek = new Dictionary<int, string>() 
{
   [1] = "Понедельник",
   [2] = "Вторник",
   [3] = "Среда",
   [4] = "Четверг",
   [5] = "Пятница",
   [6] = "Суббота",
   [7] = "Воскресенье",

};

Console.WriteLine("Введите номер дня недели");
try {
int number = Convert.ToInt32(Console.ReadLine());

    if (number > 0 && number < 6)
            Console.WriteLine($" {number}-й день недели это {dayweek[number]} и это рабочий день.");
        else 
            if (number > 5 && number < 8)
                Console.WriteLine($" {number}-й день недели это {dayweek[number]} и это выходной день.");
            else Console.WriteLine($"Вы ввели {number}, а в неделе всего 7 дней.");

}
catch{
Console.WriteLine("Вы ввели не число");
}