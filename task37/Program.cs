// 37. Задать массив, заполнить случайными положительными трёхзначными числами.
//     Показать количество нечетных\четных чисел
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
        arr[i] = new Random().Next(100, 1000); // диапазон рандома
    }
}
void CounterArr(int[] arr, ref int Even, ref int Odd) // Подсчитывает колличество чётных и не чётных числе в массиве
{
    for (int i = 0; i<arr.Length; i++)
    {
        if (arr[i] %2 == 0)
            Even++;
        else
            Odd++;
    }
}

int[] arr = new int[64];
RandomArr(arr);
System.Console.WriteLine("Есть массив, в нём случайные трёхзначные числа:");
ConsoleArr(arr);
int EvenNumber = 0;
int OddNumber = 0;
CounterArr(arr, ref EvenNumber, ref OddNumber);
System.Console.WriteLine();
System.Console.WriteLine($"  Чётных чисел: {EvenNumber}");
System.Console.WriteLine($"Нечётных чисел: {OddNumber}");

