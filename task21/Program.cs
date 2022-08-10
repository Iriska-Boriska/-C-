// 21. Задать номер четверти, показать диапазоны для возможных координат
Console.Clear();
System.Console.Write("Введи номер четверти: ");
int QuarterNumber = Convert.ToInt32(Console.ReadLine());
if (QuarterNumber == 1)
    System.Console.WriteLine($"В {QuarterNumber} четверть входят координаты больше X0 и больше Y0");
if (QuarterNumber == 2)
    System.Console.WriteLine($"В {QuarterNumber} четверть входят координаты меньше X0 и больше Y0");
if (QuarterNumber == 3)
    System.Console.WriteLine($"В {QuarterNumber} четверть входят координаты меньше X0 и меньше Y0");
if (QuarterNumber == 4)
    System.Console.WriteLine($"В {QuarterNumber} четверть входят координаты больше X0 и меньше Y0");