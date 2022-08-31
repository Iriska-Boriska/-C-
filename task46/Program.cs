// 49. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи.
// Принять первые числа равными 0 и 1
System.Console.Write($"Введи количество чисел фибоначчи, которые нажно показать: ");
int N = int.Parse(Console.ReadLine());
int PrevionsNumber = 0;
int Number = 1;
int Fibonacci = 0;
if (N>=1) {System.Console.WriteLine(PrevionsNumber);}
if (N>=2) {System.Console.WriteLine(Number);}
for(int i = 3; i<=N; i++)
{
    Fibonacci = PrevionsNumber+ Number;
    System.Console.WriteLine(Fibonacci);
    PrevionsNumber = Number;
    Number = Fibonacci;
}