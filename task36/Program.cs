// 36. Определить, присутствует ли в заданном массиве, некоторое число
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
        arr[i] = new Random().Next(0, 32); // диапазон рандома
    }
}
bool AvailabilityСheckArr(int[] arr, int N) // Проверка массива на наличие указанного числа
{
    for (int i = 0; i<arr.Length; i++)
    {
        if (arr[i] == N)
        {
            return true;
        }
    }
    return false;
}

int[] arr = new int[64];
RandomArr(arr);
System.Console.WriteLine("Есть массив, в нём числа от 0 до 32. Я скажу есть ли в нём введённое тобой число.");
ConsoleArr(arr);
System.Console.Write("Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (AvailabilityСheckArr(arr, Number))
    System.Console.WriteLine("Такое число есть");
else
    System.Console.WriteLine("Такого числа нет");

