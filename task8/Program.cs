//8. Вывести на экран числа от -N до N
Console.Clear();
System.Console.Write("Введи целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = N*(-1);
for (;i < N+1; i++)
System.Console.Write($"{i}, ");