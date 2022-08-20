// 44. Написать программу преобразования десятичного числа в двоичное
// (С большими числами программа не работает, но знаю как могла бы. 
//  Можно на 18 строчке массив не в число переводить, а в строку, а её потом в число.)
System.Console.Write("Введи число: ");
int N = int.Parse(Console.ReadLine());
ulong N2 = СonverterFrom10To2(N);
System.Console.WriteLine(N2);

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