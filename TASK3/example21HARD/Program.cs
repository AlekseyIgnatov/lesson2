// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.

Console.Write("Введите количество измерений = ");
int n = Convert.ToInt32(Console.ReadLine());
double SearchLenght(int n)
{
    int[] coord1arr = new int[n];
    int[] coord2arr = new int[n];
    double sum = 0;
    double sqrt = 0;

    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите {0}-ю координату первой точки = ", i + 1);
        coord1arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("");

    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите {0}-ю координату второй точки = ", i + 1);
        coord2arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    for (int i = 0; i < n; i++)
    {
        sum = sum + Math.Pow((coord2arr[i] - coord1arr[i]), 2);
    }
return 
sqrt = Math.Round(Math.Sqrt(sum),2);
}
Console.Write($"Длина отрезка = {SearchLenght(n)}");