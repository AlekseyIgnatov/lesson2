// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void FillArray(int[] array)
    {
       for (int i=0; i<array.Length; i++) 
            {  //array[i] = new Random().Next(-100, 101);
            Console.Write("Введите {0}-е число: ",i+1);
            array[i] = Convert.ToInt32(Console.ReadLine());
            };
    }

void PrintArray(int[] array)
    {
       foreach (int item in array)
            {
                Console.Write($"{item} ");
            }
    }

int NPositive(int[] array)
    {
        int count =0;
        for (int i=0; i < array.Length; i++)
            if (array[i] > 0) count++;
        return count;
    }


Console.Write($"Введите количество чисел ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
FillArray(array);
PrintArray(array);
Console.WriteLine("");
Console.WriteLine($"Колличество чисел больше нуля: {NPositive(array)}");
