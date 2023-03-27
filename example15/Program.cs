// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] array)
    {
       for (int i=0; i<array.Length; i++) 
            array[i] = new Random().Next(-100, 101);
    }

int SummIndNegative(int[] array)
    {
       int summ = 0;
       for (int i=0; i<array.Length; i++)
            {
                if(i%2 != 0) summ += array[i];
            }
        return summ;
    }

void PrintArray(int[] array)
    {
       foreach (int item in array)
            {
                Console.Write($"{item},");
            }
    }



int[] array = new int[4];
FillArray(array);
PrintArray(array);
Console.WriteLine("");
Console.WriteLine($"Сумма чисел стоящих в массиве на нечетных позициях: {SummIndNegative(array)}");
