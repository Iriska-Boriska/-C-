//9. Вывести на экран четные числа от 1 до N
Console.Clear();
System.Console.Write("Введи целое число больше 1: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1 ;i < N+1; i++)
System.Console.Write($"{i}, ");