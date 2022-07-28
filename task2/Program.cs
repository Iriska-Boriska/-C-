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
    Console.WriteLine($"Квадрат {Number1} равен {Number2}");
}
else
{
    if (Number2*Number2 == Number1)
    {
        Console.WriteLine($"Квадрат {Number2} равен {Number1}");
    }
    else
    {
        Console.WriteLine("Ни одно из чисел не является квадратом второго");
    };
};