// 33. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
Console.Clear();

void ConsoleArr(int[] arr) // выводит массив в консоль строчкой
{
    for (int i = 0; i<arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}; ");
    }
}
void RandomArr(int[] arr) // заполнение элементов массива случайными числами
{
    for (int i = 0; i<arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2); // диапазон рандома
    }
}

int[] arr = new int[8];
RandomArr(arr);
ConsoleArr(arr);
