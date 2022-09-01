// 47. Написать программу масштабирования фигуры
/*вершины фигуры задавать списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
*/
System.Console.WriteLine("Введи координаты вершин фигуры в формате (0,0) (2,0) (2,2) (0,2): ");
System.Console.Write("                                         ");
string s = Console.ReadLine();
char[] Sep = new char[] {'(', ')', ' ', ',', '.'};
string[] ss = s.Split(Sep, StringSplitOptions.RemoveEmptyEntries);
double [] d =Array.ConvertAll<string,double>(ss, double.Parse);

System.Console.Write("Введи коэфицент масштабирования: ");
double k = double.Parse(Console.ReadLine());

for(int i=0; i<d.Length; i++)// Масштабирование
{
    d[i]*=k;
}

System.Console.WriteLine($"({d[0]}.{d[1]}) ({d[2]}.{d[3]}) ({d[4]}.{d[5]}) ({d[6]}.{d[7]})");