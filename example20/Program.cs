// адача 2 HARD Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры), 
// причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей. Перемешать случайным 
// образом элементы массива, причем чтобы каждый элемент гарантированно и только один раз переместился на 
// другое место и выполнить перемешивание за m*n / 2 итераций. То есть если массив три на четыре, то надо 
// выполнить за 6 итераций. И далее в конце опять вывести на экран как таблицу.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
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

void Moving(int[,] array, int[,]array2)
{
    int i = 0;
    int j = 0;
    int i1 = 0;
    int j1 = 0;
    int num = 0;
    for (int k = 0; k < (array.GetLength(0)*array.GetLength(1))/2; k++)
        {
            bool a = false;
            bool b = false;
            while (a==false)
                {
                    i = new Random().Next(0, array.GetLength(0));
                    j = new Random().Next(0, array.GetLength(1));
                    if (array2[i,j]==0) a = true;
                }
            array2[i,j] = 1;
            while (b==false)
                {
                    i1 = new Random().Next(0, array.GetLength(0));
                    j1 = new Random().Next(0, array.GetLength(1));
                    if (array2[i1,j1]==0) b = true;                 
                }
            array2[i1,j1] = 1;
            Console.WriteLine($"Итерация {k+1}, выбраны координаты {i},{j} и {i1},{j1}");
            num = array[i,j];
            array[i,j] = array[i1,j1];
            array[i1,j1] = num;
            Console.WriteLine("");
            PrintArray(array);
            Console.WriteLine("");

        }
}



int rows = 0;
int columns = 0;
bool a = false;
while(a==false)
    {
        Console.Write($"Введите количество строк: ");
        rows = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Введите количество столбцов: ");
        columns = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        int n = rows * columns%2;
        if(n == 0) a = true;
            else Console.WriteLine($"Количество элементов в массиве должно быть четным!");
    }



int[,] array = new int[rows, columns];
int[,] array2 = new int[rows, columns];

FillArray(array);
PrintArray(array);
Console.WriteLine("");
Moving(array, array2);