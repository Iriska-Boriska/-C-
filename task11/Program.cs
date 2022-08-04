// 11. Дано число больше 9. Вывести на экран  вторую цифру числа с конца

Console.Clear();
System.Console.WriteLine("Введи число больше 9: ");
int X = Convert.ToInt32 (Console.ReadLine ());
System.Console.WriteLine(X/10%10);