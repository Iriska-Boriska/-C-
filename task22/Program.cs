// 22. Программа проверяет пятизначное число на палиндромом.
Console.Clear();
System.Console.Write("Введи пятизначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int InvertedNumber = (Number%10)*10000 + (Number%100/10)*1000 + (Number%1000/100)*100 + (Number%10000/1000)*10 + (Number%100000/10000);
if (Number == InvertedNumber)
    System.Console.WriteLine($"{Number} - палиндром");
else
    System.Console.WriteLine($"{Number} - не палиндром");
// Можно было проще, но я сначала подумал, что палиндром это просто когда переворачивают число, а не зеркалное. 