// 20. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.Clear();
System.Console.WriteLine("Ниже введи координаты точки, причем X ≠ 0 и Y ≠ 0");
System.Console.Write("Введи координату X: ");
int X = Convert.ToInt32 (Console.ReadLine());
System.Console.Write("Введи координату Y: ");
int Y = Convert.ToInt32 (Console.ReadLine());
if (X>0)
    if (Y>0)
        System.Console.WriteLine("Точка в 1 четверти");
    else
        System.Console.WriteLine("Точка в 4 четверти");
else
    if (Y>0)
        System.Console.WriteLine("Точка в 2 четверти");
    else
        System.Console.WriteLine("Точка в 3 четверти");