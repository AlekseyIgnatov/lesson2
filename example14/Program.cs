// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] array)
    {
       for (int i=0; i<array.Length; i++) 
            array[i] = new Random().Next(100, 1000);
    }

int SearchPositive(int[] array)
    {
       int count = 0;
       for (int i=0; i<array.Length; i++)
            {
                if(array[i]%2 ==0) count++;
            }
        return count;
    }

void PrintArray(int[] array)
    {
       foreach (int item in array)
            {
                Console.Write($"{item}.");
            }
    }



int[] array = new int[4];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Колличество четных чисел в массиве: {SearchPositive(array)}");