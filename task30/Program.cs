// 30. Написать программу вычисления произведения чисел от 1 до N
Console.Clear();
System.Console.WriteLine("Я покажу произведение всех чисел от 1 до введённого числа.");
System.Console.WriteLine("Введи целое число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int result = 1;
for(int i=2; i<=Number; i++)
    result = result*i;
System.Console.WriteLine(result);