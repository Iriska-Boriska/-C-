// 43. С клавиатуры вводится число N. Затем вводятся N чисел.
//     Определить сколько чисел больше 0 введено с клавиатуры
Console.Clear();
System.Console.Write("Введи число: ");
int N = Int32.Parse(Console.ReadLine());
System.Console.Write("Введи ещё несколько чисел через пробел: ");
int[] Numbers = null;
EnteringIntsOnOneLineArr(out Numbers, ' ');
int count = 0;

if (N > 0) { count += 1;}
for (int i = 0; i < Numbers.Length; i++)
{
    if (Numbers[i]>0) {count += 1;}
}

System.Console.WriteLine($"{count} чисел больше нуля среди введённых");



void EnteringIntsOnOneLineArr(out int[] SNumbers, char separator) // Наполняет массив введёнными в консоль числами разделёнными separator
{
    string S = Console.ReadLine();
    string[] SText = S.Split(separator);
    SNumbers = new int[SText.Length];
    for (int i = 0; i < SNumbers.Length; i++)
    {
        SNumbers[i] = int.Parse(SText[i]);
    }
}