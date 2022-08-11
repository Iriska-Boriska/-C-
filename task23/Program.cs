// 23. Найти расстояние между точками в пространстве 2D
Console.Clear();

System.Console.WriteLine("Я наду расстояние между точками A и B.");
System.Console.WriteLine("Введи ниже их координаты.");
System.Console.Write("Ax = ");
double Ax = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Ay = ");
double Ay = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Bx = ");
double Bx = Convert.ToDouble(Console.ReadLine());
System.Console.Write("By = ");
double By = Convert.ToDouble(Console.ReadLine());

double RVeсtor = Math.Sqrt(Math.Pow((Ax - Bx),2) + Math.Pow((Ay - By),2));
System.Console.WriteLine($"Между точками: {RVeсtor}");