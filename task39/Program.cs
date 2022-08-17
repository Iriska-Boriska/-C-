// 39. Найти сумму чисел одномерного массива стоящих на нечетной позиции
//(я бы здесь уточнил нечётная при счёте от 0 или от 1, но суть программы останется прежняя)
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
        arr[i] = new Random().Next(start, end + 1); // диапазон рандома
    }
}

int[] arr = new int[6];
int ArrayStartRandom = 0;
int ArrayEndRandom = 10;
RandomArr(arr, ArrayStartRandom, ArrayEndRandom);
System.Console.WriteLine($"Есть массив, в нём случайные числа от {ArrayStartRandom} до {ArrayEndRandom}:");
ConsoleArr(arr);

int Sum = 0;
for (int i = 1; i < arr.Length; i += 2)
{
    Sum += arr[i];
}

System.Console.WriteLine();
System.Console.WriteLine($"Сумма чисел стоящих на нечетной позиции: {Sum}");

