// 29. Подсчитать сумму цифр в числе
Console.Clear();
System.Console.WriteLine("Я посчитаю сумму цифр в числе N.");
System.Console.Write("   Введи N: ");
string StringN = Console.ReadLine();
int LengthN = StringN.Length;
int Sum = 0;
for (int i=0; i<(LengthN); i++)
    Sum = Sum + Convert.ToInt32(StringN[i]) - 48; //Не знаю почему нужно вычесть 48, но иначе не работает)
System.Console.WriteLine($"Сумма цифр: {Sum}");



/*
int Length = LengthNanber(N);
int Sum = N%10;
double j = 0;
for (int i=2; i<=Length; i++)
    j = Convert.ToDouble(i);
    Sum = Sum + N%Convert.ToInt32((Math.Pow(j, 10)))/Convert.ToInt32((Math.Pow(j-1, 10)));
System.Console.WriteLine(Sum);
*/
