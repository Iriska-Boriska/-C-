// 49. Показать двумерный массив размером m×n заполненный вещественными случайными числами

System.Console.Write("Укажи размер мвссива m*n:\nm = ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("n = ");
int n = int.Parse(Console.ReadLine());

double[,] Array = new double[m, n];
RandomArr2Double(Array);
ConsoleArr2(Array);



void RandomArr2Double(double[,] arr) // заполнение элементов [,] массива случайными числами
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().NextDouble();
        }
    }
}
void ConsoleArr2(double[,] arr) // выводит массив в консоль строчкой
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]}; ");
        }
        System.Console.WriteLine();
    }
}
