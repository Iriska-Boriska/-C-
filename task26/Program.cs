// 26. Найти сумму чисел от 1 до А
Console.Clear();
System.Console.WriteLine("Я покажу сумму чисел от 1 до А включительно.");
System.Console.Write("Введи A: ");
int A = Convert.ToInt32(Console.ReadLine());
int Sam = 0;
for (int i=0; i<=A; i++)
    Sam = Sam + i;
System.Console.WriteLine(Sam);