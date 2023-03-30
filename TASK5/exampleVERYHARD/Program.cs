// Задача VERY HARD необязательная Имеется массив случайных целых чисел. 
// Создайте массив, в который попадают числа, описывающие максимальную 
// сплошную возрастающую последовательность. Порядок элементов менять нельзя.
// Одно число - это не последовательность.


void FillArray(int[] array)
    {
       for (int i=0; i<array.Length; i++) 
            {  
                array[i] = new Random().Next(0, 10);
            };
    }

void PrintArrayStart(int[] array)
    {
       foreach (int item in array)
            {
                Console.Write($"{item},");
            }
    }

void Posl(int[] array)
    {
        int count = 1;
        int n = 1;
        for (int i=0; i<array.Length; i++)
            {
               for (int j=0; j<array.Length; j++) 
                {
                if (array[i]+1 == array[j]) 
                    {
                        count ++;
                    }
                    else 
                        {
                            array2[0] = array[i];
                            array2[1] = count;
                            count = 0;
                        }
                }        
            }

    }


int[] array = new int[6];
Console.WriteLine("");
FillArray(array);
MinNum(array);
PrintArrayStart(array);
Console.WriteLine($" {MinNum(array)}");
Posl(array);