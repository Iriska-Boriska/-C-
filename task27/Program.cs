// 27. Возведите число А в натуральную степень B используя цикл
Console.Clear();
System.Console.WriteLine("Я вщзведу A в натуральную степень B.");
System.Console.Write("Введи A: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введи B: ");
int B = Convert.ToInt32(Console.ReadLine());
int Result = A;
for (int i=1; i<B; i++)
    Result = Result*A;
System.Console.WriteLine(Result);
