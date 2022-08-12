// 28. Определить количество цифр в числе. Сделать подпрограмму.
int LengthNanber (int Nanber)
{
    int Amount = Convert.ToString(Nanber).Length;
    return Amount;
}
Console.Clear();
//Length
System.Console.WriteLine("Я покажу кол-во цифр в числе N.");
System.Console.Write("Введи N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(LengthNanber (N));