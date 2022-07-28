/*С клавиатуры вводятся два вещественных числа. 
Проверять является ли одно из них квадратом второго*/

Console.Clear();
double Number1 = 0;
double Number2 = 0; 
Console.WriteLine ("Я проверю является ли первое число квадратом второго.");
Console.Write ("Введи первое число: ");
Number1 = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введи второе число: ");
Number2 = Convert.ToDouble (Console.ReadLine());
if (Number1*Number1 == Number2)
{
    Console.WriteLine("Квадрат {0} равен {1}", Number1, Number2);
}
else
{
    Console.WriteLine("Квадрат {0} не равен {1}", Number1, Number2);
};