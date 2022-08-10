// 18. По двум заданным числам проверять является ли одно квадратом другого. Используйте подпрограмму.
Console.Clear();
bool CheckingForASquare (int a, int b)
{
    if (a*a==b || b*b==a)
        return (true);
    else
        return (false);
}
    
System.Console.Write("Введи a: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введи b: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
if (CheckingForASquare(NumberA, NumberB))
    System.Console.WriteLine("Одно из чисел является квадратом другого");
else
    System.Console.WriteLine("Ни одно из чисел не является квадратом другого");