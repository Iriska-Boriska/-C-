// 24. Вывести на экран таблицу квадратов чисел от 1 до N
Console.Clear();

string String0 (int N) //Создаёт верхнюю строку (N) - маскимальное число в строке
{
    string STR0 = "___|";
    for (int i=0; i<N; i++)
        STR0 = STR0 + $"{i+1}_____";
    return STR0;
}
string StringN (int N, int m) //Создаёт строку с умноженными на (m) значениями, (N) - маскимальное умножаемое в строке
{
    string STR0 = $"{m}  |";;
    for (int i=1; i<=N; i++)
        STR0 = STR0 + $"{i*m}     ";
    return STR0;
}

int N = Convert.ToInt32(Console.ReadLine());  //Каким числом закончить таблицу
System.Console.WriteLine(String0(N));
for (int i=1; i<=N; i++)                      // В (i) указываем с какого числа начинать строки
    System.Console.WriteLine(StringN(N, i));
