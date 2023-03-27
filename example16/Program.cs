//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] array)
    {
       for (int i=0; i<array.Length; i++) 
            {  //array[i] = new Random().Next(-100, 101);
            Console.Write("Введите {0}-й элемент массива: ",i+1);
            array[i] = Convert.ToDouble(Console.ReadLine());
            };
    }

double RaznMaxMin(double[] array)
    {
       double max = array[0];
       double min = array[0];
       double razn = 0;
       int i = 1;
       while(i < array.Length)
            {
                if(max < array[i]) max = array[i];
                if(min > array[i]) min = array[i];
                i++;
            }
        razn = max-min;
        return razn;
    }

void PrintArray(double[] array)
    {
       foreach (double item in array)
            {
                Console.Write($"{item},");
            }
    }



double[] array = new double[5];
FillArray(array);
PrintArray(array);
Console.WriteLine("");
Console.WriteLine($"Разность максимального и минимального элементов массива: {RaznMaxMin(array)}");
