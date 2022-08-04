//10. Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
Console.Clear();
System.Console.Write ("Введи число: ");
int X = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine(X%10);