/*
14. С клавиатуры вводятся два числа a и b.
Выяснить, кратно ли число a числу b,
если нет, вывести остаток от деления a на b.
*/
Console.Clear();
System.Console.Write("Введи число a: ");
int a = Convert.ToInt32 (Console.ReadLine());
System.Console.Write("Введи число b: ");
int b = Convert.ToInt32 (Console.ReadLine());
int Modulo = a%b;
if (Modulo == 0)
    System.Console.WriteLine($"{a} кратно {b}");
else
    System.Console.WriteLine($"{a} не кратно {b}, остаток от деления = {Modulo}");