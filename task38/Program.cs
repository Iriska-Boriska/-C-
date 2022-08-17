// 38. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

Console.Clear();
void ConsoleArr(int[] arr) // выводит массив в консоль строчкой
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}; ");
    }
    System.Console.WriteLine();
}
void RandomArr(int[] arr, int start, int end) // заполнение элементов массива случайными числами
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(start, end+1); // диапазон рандома
    }
}
int ElementsMatchingTheConditionArr(int[] arr, ref int first, ref int last) // Подсчитывает колличество элементов значение которых входят в отрезок включительно
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= first && arr[i] <= last)
            count++;
    }
    return count;
}

int[] arr = new int[123];
int ArrayStartRandom = 0;
int ArrayEndRandom = 999;
RandomArr(arr, ArrayStartRandom, ArrayEndRandom);
System.Console.WriteLine($"Есть массив, в нём случайные числа от {ArrayStartRandom} до {ArrayEndRandom}:");
ConsoleArr(arr);
int FirstOfTheSegment = 10;
int LastOfTheSegment = 99;
int count = ElementsMatchingTheConditionArr( arr, ref FirstOfTheSegment, ref LastOfTheSegment);

System.Console.WriteLine();
System.Console.WriteLine($"Чисел в массиве из отрезка [{FirstOfTheSegment},{LastOfTheSegment}]: {count}");


