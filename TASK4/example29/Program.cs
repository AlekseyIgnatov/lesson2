// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] arr = new int[8];

void FillArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(0,100);
}

void PrintArr(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]},");
}

FillArr(arr);
PrintArr(arr);
