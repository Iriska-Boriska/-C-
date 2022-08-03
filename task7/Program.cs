//7. Выяснить является ли число чётным.
Console.Clear();
System.Console.WriteLine("Я проверю чётное ли число./nВведи число:");
System.Console.WriteLine("Введи целое число: ");
int Number = Convert.ToInt32 (Console.ReadLine());
if (Number%2 == 0)
    System.Console.WriteLine("Число чётное");
else
    System.Console.WriteLine("Число не чётное");