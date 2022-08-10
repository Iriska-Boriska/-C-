// 16. Дано число. Проверить кратно ли оно 7 и 23
Console.Clear();
System.Console.WriteLine("Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());
bool N7 = Number%7 == 0;
bool N23 = Number%23 == 0;
if (N7 && N23)
    System.Console.WriteLine($"{Number} кратно одновременно 7 и 23");
else
    System.Console.WriteLine($"{Number} НЕ кратно одновременно 7 и 23");
