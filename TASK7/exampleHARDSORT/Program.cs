// Задача HARD SORT необязательная. Задайте двумерный массив из целых чисел. 
// Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 11);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}

void CopyArray(int[,] array, int [] array2)
{
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array2[k++] = array[i, j];
}

void CopyArray2(int[,] array, int [] array2)
{
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j]=array2[k++];
}

void SortArray(int[] array2)
    {
        int num = 0;  
        for (int i = 0; i < array2.Length; i++)
            for (int j = i+1; j < array2.Length; j++)
                {
                if (array2[i] > array2[j]) 
                    {
                        num = array2[i];
                        array2[i] = array2[j];
                        array2[j] = num;
                    }
                }

    }




Console.Write($"Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

int n = rows * columns;
int[,] array = new int[rows, columns];
int[] array2 = new int[n];

FillArray(array);
PrintArray(array);
CopyArray(array, array2);
SortArray(array2);
CopyArray2(array, array2);
Console.WriteLine("");
PrintArray(array);