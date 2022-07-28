/*С клавиатуры вводятся два числа a и b. Найти максимальное из них.*/

Console.Clear();
double Number_a = 0;
double Number_b = 0;

Console.WriteLine ("Я найду тебе максимальное число из двух.");
Console.Write ("Введи число: a = ");
Number_a = Convert.ToDouble (Console.ReadLine ());
Console.Write ("Введи число: b = ");
Number_b = Convert.ToDouble (Console.ReadLine ());

if (Number_a == Number_b)
{
    Console.WriteLine ("Введённные числа равны");
}
else
{
    if (Number_a > Number_b)
    {
        Console.WriteLine ($"Большее число: a = {Number_a}");
    }
    else
    {
        Console.WriteLine ($"Большее число: b = {Number_b}");
    };
};