void ConsoleArr1(int[] arr) // выводит [] массив в консоль строчкой
{
    for (int i = 0; i<arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}; ");
    }
    System.Console.WriteLine();
}

void ConsoleArr2(int[,] arr) // выводит [,] массив в консоль строчкой
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

void RandomArr1(int[] arr, int start, int end) // заполнение элементов [] массива случайными числами
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(start, end+1); // диапазон рандома
    }
}

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

void RandomArr2Double(double[,] arr) // заполнение элементов [,] массива случайными числами
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().NextDouble();
        }
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

int ArrayReleaseBy2(int[] arr) // делит чётное кол-во на 2, а нечётное на /2 и +1
{
    if (arr.Length % 2 == 0) return arr.Length / 2;
    else return arr.Length / 2 + 1;
}

double MaxElementArr(double[] arr) // Поиск максимального элемента
{
    double Max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > Max) Max = arr[i];
    }
    return Max;
}

double MinElementArr(double[] arr) // Поиск минимального элемента
{
    double Min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < Min) Min = arr[i];
    }
    return Min;
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

ulong СonverterFrom10To2(int N10) // Конвертирует десятичное чксло от 6 включительно в двоичное
{
    int LengthN2 = Convert.ToInt32(Math.Log2(Convert.ToDouble(N10)))+10;
    int[] N2Array = new int[LengthN2];
    for (int i = 0; i < LengthN2; i++)
    {
        N2Array[i] = N % 2;
        N /= 2;
    }
    ulong N2 = 0;
    for (int i = 0; i < N2Array.Length; i++)
    {
        N2 += Convert.ToUInt64(N2Array[i]) * Convert.ToUInt64(Math.Pow(10.0, Convert.ToDouble(i)));
    }
    return N2;
}







