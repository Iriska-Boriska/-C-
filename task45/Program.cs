// 45. Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы


/*
Не работает. Проверять не нужно.
*/


double
b1 = 5,
k1 = 7,
b2 = 11,
k2 = 44;
bool Stop = false;
int Case = 0;
if (k1 == k2 && b1 == b2) { Stop = true; Case = 1; } //Линии совпадают
if (Stop == false && k1 == k2) { Stop = true; Case = 2; } //Линии параллельны
double x = 0;
if (Stop == false && k1 * x + b1 == k2 * x + b2) { Stop = true; Case = 3; } //Тoчка перечечения в X = 0
if (Stop == false)
{
    double //переменные размера разницы в "y" при одинкаовом "x"
    dYx0 = Math.Abs(Y1(x, b1, k1) - Y2(x, b2, k2)),
    dYx10 = Math.Abs(Y1(x + 10.0, b1, k1) - Y2(x + 10.0, b2, k2)),
    dYx20 = Math.Abs(Y1(x + 20.0, b1, k1) - Y2(x + 20.0, b2, k2)),
    dYx30 = Math.Abs(Y1(x + 30.0, b1, k1) - Y2(x + 30.0, b2, k2));
    double SearchDirection = 0.0;
    if (dYx0 < dYx10
        && dYx10 < dYx20
        && dYx20 < dYx30) { SearchDirection = -1.0; x += 30.0; }
    else { SearchDirection = 1.0; }
    double i = 1000.0; //Множитель шага
    double j = 1.0; //Коэффицент шага 
    double dYxCurrentPoint = 0.0;
    double dYxNextPoint = Math.Abs(Y1(x + SearchDirection * i/1000 * j, b1, k1) - Y2(x + SearchDirection * i/1000 * j, b2, k2));//Math.Abs(Y1(x, b1, k1) - Y2(x, b2, k2));
    bool CrossingTheDesiredPoint = false;
    while (i > 0.00001) //Условие цикла задаёт точность
    {
        if (CrossingTheDesiredPoint == false)
        { dYxCurrentPoint = dYxNextPoint; }
        else { CrossingTheDesiredPoint = false; }
        dYxNextPoint = Math.Abs(Y1(x + SearchDirection * i * j, b1, k1) - Y2(x + SearchDirection * i * j, b2, k2));
        if (dYxNextPoint < dYxCurrentPoint) { j += 1.0; }
        else
        {
            x = x + SearchDirection * i * (j - 1.000001);
            CrossingTheDesiredPoint = true;
            i /= 10; //Делим шаг на 10
            j = 0.000001; //Сбразываем коэффицент
        }
    }
}
System.Console.WriteLine(x);

double Y1(double x, double b1, double k1) // Y1(x, b1, k1)
{ return k1 * x + b1; }
double Y2(double x, double b2, double k2) // Y2(x, b2, k2)
{ return k2 * x + b2; }


