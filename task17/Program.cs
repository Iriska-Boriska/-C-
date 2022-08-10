// 17. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Clear();
System.Console.WriteLine("Введи номер дня недели (1-7): ");
int DayNumber = Convert.ToInt32(Console.ReadLine());
if (DayNumber >= 6)
    System.Console.WriteLine("Это выходной");
else
    System.Console.WriteLine("Это рабочий день");
