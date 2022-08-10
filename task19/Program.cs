// 19. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y 
//                                      !(X || Y)==!X && !Y

Console.Clear();
bool X = true;
bool Y = true;
System.Console.WriteLine($"   X  |   Y   | Результат !(X || Y)==!X && !Y ");
System.Console.WriteLine($" {X} | {Y} |             {!(X || Y)==!X && !Y}");
X=!X;
System.Console.WriteLine($" {X} | {Y} |             {!(X || Y)==!X && !Y}");
X=!X;
Y=!Y;
System.Console.WriteLine($" {X} | {Y} |             {!(X || Y)==!X && !Y}");
X=!X;
System.Console.WriteLine($" {X} | {Y} |             {!(X || Y)==!X && !Y}");

/*
Console.Clear();
bool X = true;
bool Y = true;
int i = 0;
System.Console.WriteLine($"  X  |  Y  | Результат !(X || Y)==!X && !Y ");
while (i==3)
    System.Console.WriteLine($" {X} | {Y} |             {!(X || Y)==!X && !Y}");
    if (i==1)
        X=!X;
    if (i==2)
        X=!X;
        Y=!Y;
    if (i==3)
        X=!X;
    i++;
*/