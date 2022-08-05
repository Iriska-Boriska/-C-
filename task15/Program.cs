// 15. С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет
Console.Clear ();
System.Console.Write ("Введи целое число: ");
string Namber = Console.ReadLine();
if (Convert.ToInt32(Namber) > 99)
    System.Console.WriteLine(Namber.Substring(2, 1));
else
    System.Console.WriteLine("В указанном числе нет 3 цифры");


