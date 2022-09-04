﻿// 48.2 Показать двумерный массив размером m×n заполненный целыми случайными числами
System.Console.Write("Укажи размер мвссива m*n:\nm = ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("n = ");
int n = int.Parse(Console.ReadLine());

int[,] Array = new int[m, n];
RandomArr2(Array, 0, 9);
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
