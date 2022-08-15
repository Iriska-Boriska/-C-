// 35. Написать программу замены элементов массива на противоположные
Console.Clear();
void ConsoleArr(int[] arr) // выводит массив в консоль строчкой
{
    for (int i = 0; i<arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}; ");
    }
    System.Console.WriteLine();
}
void RandomArr(int[] arr) // заполнение элементов массива случайными числами
{
    for (int i = 0; i<arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10); // диапазон рандома
    }
}
void MultiplyByMinus1Arr(int[] arr) // Умножение массива на -1
{
    for (int i = 0; i<arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
}

int[] arr = new int[12];
RandomArr(arr);
ConsoleArr(arr);
MultiplyByMinus1Arr(arr);
ConsoleArr(arr);


