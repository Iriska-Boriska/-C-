// 32. Задать массив из 8 целых элементов и вывести их на экран
Console.Clear();
int[] arr = {784, 73, 18, 44, 023, 46274, 60476024, 2};
for (int i = 0; i<arr.Length; i++)
{
    System.Console.Write($"{arr[i],10}");
}




/*
void RandomFillingArrayInt32(int [] Array, int a, int z) // "a" и "z" - первое и послепоследнее число проежутка рандома
{
    int Length = Array.Length;
    for (int i = 0; i<=Length; i++)
    {
        Array[i] = new Random().Next(a, z);
    }
}

int[] arr = new int [8];
int a = 0;
int z = 11;
RandomFillingArrayInt32(arr, a, z);
System.Console.WriteLine(arr[4]);
*/