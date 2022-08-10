// 22. Программа проверяет пятизначное число на палиндромом.
Console.Clear();
/*
int ConvtrtToPalindrome5 (int A)
{
    int End = (A%100000) + (A%10000) + (A%1000) + (A%100) + (A%10);
    return End;
}
*/

System.Console.Write("Введи пятизначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int Palindrome = (Number%10)*10000 + (Number%100/10)*1000 + (Number%1000/100)*100 + (Number%10000/1000)*10 + (Number%100000/10000);
System.Console.WriteLine($"      Вот его палиндром: {Palindrome}");
