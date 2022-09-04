// 50. В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j])
System.Console.Write("Укажи размер мвссива m*n:\nm = ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("n = ");
int n = int.Parse(Console.ReadLine());

int[,] Array = new int[m, n];
RandomArr2(Array, 0, 9);
ConsoleArr2(Array);
Replacement(Array);
System.Console.WriteLine();
ConsoleArr2(Array);




void RandomArr2(int[,] arr, int start, int end) // заполнение элементов [,] массива случайными числами
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(start, end + 1); // диапазон рандома
        }
    }
}
void ConsoleArr2(int[,] arr) // выводит массив в консоль строчкой
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
void Replacement(int[,] arr) 
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] % 2 == 0)
            { arr[i, j] = -arr[i, j]; }
        }
    }
}
