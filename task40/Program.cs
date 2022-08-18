// 40. Задан массив a (пусть будет arr) из N элементов. Заполнить массив случайными числами от 1 до 10.
// Создайте массив, который является произведением пар чисел в одномерном массиве a.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//(В задании не оговорено что делать с нечётными массивами, что-бы лишний раз потренироваться
// пусть центральный элемент не игнорируется, а умножаеется сам на себя)
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
int ArrayReleaseBy2(int[] arr) // делит чётное кол-во на 2, а нечётное на /2 и +1
{
    if (arr.Length % 2 == 0) return arr.Length / 2;
    else return arr.Length / 2 + 1;
}
System.Console.Write("Введи колличество элементов в массиве: ");
int AmountOfElements = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[AmountOfElements];
int ArrayStartRandom = 0;
int ArrayEndRandom = 10;
RandomArr(arr, ArrayStartRandom, ArrayEndRandom);
System.Console.WriteLine($"Есть массив, в нём случайные числа от {ArrayStartRandom} до {ArrayEndRandom}:");
ConsoleArr(arr);

int[] NewArray = new int[ArrayReleaseBy2(arr)];
for (int i = 0; i <= NewArray.Length-1; i++)
{
    NewArray[i] = arr[i] * arr[arr.Length - 1 - i];
}
ConsoleArr(NewArray);
