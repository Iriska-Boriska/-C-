// 41. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.Clear();
void ConsoleArr(double[] arr) // выводит массив в консоль строчкой
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}; ");
    }
    System.Console.WriteLine();
}
void RandomArr(double[] arr, int start, int end) // заполнение элементов массива случайными числами
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(start, end + 1) + new Random().NextDouble(); // диапазон рандома
    }
}
double MaxElementArr(double[] arr)
{
    double Max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > Max) Max = arr[i];
    }
    return Max;
}
double MinElementArr(double[] arr)
{
    double Min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < Min) Min = arr[i];
    }
    return Min;
}

double[] arr = new double[6];
int ArrayStartRandom = 0;
int ArrayEndRandom = 10;
RandomArr(arr, ArrayStartRandom, ArrayEndRandom);

System.Console.WriteLine($"Есть массив, в нём случайные числа от {ArrayStartRandom} до {ArrayEndRandom}:");
ConsoleArr(arr);
System.Console.WriteLine($"Разница между максимальным и минимальным элементом: {MaxElementArr(arr) - MinElementArr(arr)}");

