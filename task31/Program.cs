// 31. Показать кубы чисел, заканчивающихся на четную цифру
Console.Clear();
System.Console.WriteLine("Кубы чисел, заканчивающихся на четную цифру:");
int LastValue = 100;
int Cube = 0;
int i = 0;
while (i<=LastValue)
{
    Cube = i*i*i;
    if (Cube%2 == 0)
    {
        System.Console.WriteLine($"{i}^3 = {Cube}");
    }
    Cube = 0;
    i++;
}