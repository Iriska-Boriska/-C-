// 13. Удалить вторую цифру целого числа введенного с клавиатуры.
Console.Clear();
System.Console.Write ("Введи целое число больше 9: ");
string Number = (Console.ReadLine());
System.Console.WriteLine( Number.Remove (1, 1));
