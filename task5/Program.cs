//С клавиатуры вводятся три числа. Найти максимальное из трех чисел

Console.Clear();
double a = 0;
double b = 0;
double c = 0;
double Max = 0;
System.Console.WriteLine ("Введи 3 числа: ");
System.Console.Write ("a = ");
a =Convert.ToInt32( Console.ReadLine ());
System.Console.Write ("b = ");
b =Convert.ToInt32( Console.ReadLine ());
System.Console.Write ("c = ");
c =Convert.ToInt32( Console.ReadLine ());
Max = a;
if (b > Max) Max = b;
if (c > Max) Max = c;
System.Console.WriteLine($"Большее из них: {Max}");
