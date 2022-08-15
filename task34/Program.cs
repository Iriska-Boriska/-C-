// 34. Задать массив из 12 элементов, заполненных числами из [-9, 9].
// Найти сумму положительных/отрицательных элементов массива

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
        arr[i] = new Random().Next(-9, 10); // диапазон рандома
    }
}

int[] arr = new int[12];
RandomArr(arr);

int SumPositiveElements = 0;
int SumNegativeElements = 0;

for (int i = 0; i<arr.Length; i++)
{
    if(arr[i] < 0)
    SumNegativeElements = SumNegativeElements + arr[i];
    else
    SumPositiveElements = SumPositiveElements + arr[i];
}

System.Console.WriteLine($"Сумма отрицательных: {SumNegativeElements}");
System.Console.WriteLine($"Сумма положительных: {SumPositiveElements}");