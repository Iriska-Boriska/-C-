// 42. Выяснить являются ли три числа сторонами треугольника
Console.Clear();
System.Console.WriteLine("Введи ниже через пробел длины сторон треугольниуов:");
int[] Num = new int[3];
EnteringIntsOnOneLineArr(Num, ' ');

if (Num[0] + Num[1] > Num[2]
 && Num[2] + Num[0] > Num[1]
 && Num[1] + Num[2] > Num[0])
{
    System.Console.WriteLine("Числа являются сторонами треугольника");
}
else { System.Console.WriteLine("Числа НЕ являются сторонами треугольника"); }

void EnteringIntsOnOneLineArr(int[] SNumbers, char separator) // Наполняет массив введёнными в консоль числами разделёнными separator
{
    string S = Console.ReadLine();
    string[] SText = S.Split(separator);
    for (int i = 0; i < SNumbers.Length; i++)
    {
        SNumbers[i] = int.Parse(SText[i]);
    }
}

