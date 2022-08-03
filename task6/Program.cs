//Написать программу вычисления значения функции y = sin(a). (Класс Math). 
Console.Clear();
System.Console.Write ("Введи угол в градусах: ");
double AngleInDegrees = Convert.ToDouble (Console.ReadLine());
double AngleInRadias = AngleInDegrees/180*Math.PI;
System.Console.WriteLine (Math.Round (Math.Sin(AngleInRadias),2));
