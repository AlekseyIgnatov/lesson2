//Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
//Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, 
//среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и 
//вывести на экран с пояснениями. Найти медианное значение первоначалального массива , 
//возможно придется кое-что для этого дополнительно выполнить.

void FillArray(int[] array)
    {
       for (int i=0; i<array.Length; i++) 
            {  
                array[i] = new Random().Next(0, 10);
            };
    }

void MaxMinInd(int[] array, double[] array2)
    {
        array2[1] = array[0];
        array2[3] = array[0];
        int i = 1;
       
       while(i < array.Length)
            {
                if(array2[1] < array[i]) 
                    {
                        array2[1] = array[i];
                        array2[0] = i;
                    };
                if(array2[3] > array[i]) 
                    {
                        array2[3] = array[i];
                        array2[2] = i;
                    };
                i++;
            }
       
    }

void SredneeArifm(int[] array, double[] array2)
    {
        for (int i=0; i < array.Length; i++)
            {
                array2[4] += array[i];
            }
        array2[4] = array2[4]/array.Length;  
    }

void SortArray(int[] array)
    {
        int num = 0;
        for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                if (array[i] > array[j]) 
                    {
                        num = array[i];
                        array[i] = array[j];
                        array[j] = num;
                    };
                }
            }
    }

void Mediana (int[] array, double[] array2)
    {
        if (array.Length%2 == 0) 
            {
                array2[5] =  array[array.Length/2-1] + array[array.Length/2];
            }
            else array2[5] = array[array.Length/2];
    }

void PrintArray(double[] array2)
   {    
        Console.WriteLine("");
        Console.WriteLine($"Максимальное число в массиве {array2[1]} его индекс {array2[0]}");
        Console.WriteLine($"Минимальное число в массиве {array2[3]} его индекс {array2[2]}");
        Console.WriteLine($"Сренее арифметическое элементов массива {array2[4]}");
        Console.WriteLine($"Медиана массива {array2[5]}");
   }

void PrintArrayStart(int[] array)
    {
       foreach (int item in array)
            {
                Console.Write($"{item},");
            }
    }



int[] array = new int[6];
double[] array2 = new double[6];
Console.WriteLine("");
FillArray(array);
MaxMinInd(array, array2);
SredneeArifm(array, array2);
PrintArrayStart(array);
SortArray(array);
Mediana(array, array2);
//Console.WriteLine("");
//PrintArrayStart(array);
PrintArray(array2);
