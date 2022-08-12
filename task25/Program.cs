// 25. Вывести на экран кубы чисел от 1 до N
Console.Clear();
System.Console.Write("Введи N: ");
int N = Convert.ToInt32(Console.ReadLine());
for(int i=1; i<=N; i++)
    System.Console.WriteLine($"Куб {i} = {i*i*i}");