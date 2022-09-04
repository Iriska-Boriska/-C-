// 48. Написать программу копирования массива
int NumbersLength = 6;
System.Console.WriteLine($"Введи ниже массив из {NumbersLength} целых чисел разделяя их пробелами:");
int[] Numbers = new int [NumbersLength]; // test: 3 9 0 -45 -5 3
char separator = ' ';
EnteringIntsOnOneLineArr(Numbers, separator);
System.Console.WriteLine("Получился массив <<Numbers>>");
ConsoleArr(Numbers);
int[] NumbersCopy = null;
CopeArr(Numbers, out NumbersCopy);
System.Console.WriteLine("А вот его копия, массив <<NumbersCopy>>");
ConsoleArr(NumbersCopy);

void CopeArr(int[] Original, out int[] Copy) //Делает копию массива
{
    Copy = new int [Original.Length];
    for (int i = 0; i < Copy.Length; i++)
    {
        Copy[i] = Original[i];
    }
}
void EnteringIntsOnOneLineArr(int[] SNumbers, char separator) // Заполняет массив введёнными в консоль числами разделёнными separator
{
    string S = Console.ReadLine();
    string[] SText = S.Split(separator);
    for (int i = 0; i < SNumbers.Length; i++)
    {
        SNumbers[i] = int.Parse(SText[i]);
    }
}
void ConsoleArr(int[] arr) // выводит массив в консоль строчкой
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}; ");
    }
}