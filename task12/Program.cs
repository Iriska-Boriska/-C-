// 12. С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
Console.Clear();
System.Console.Write ("Введи двузначное число: ");
int Number = Convert.ToInt32 (Console.ReadLine());
int Number1 = Number/10;
int Number2 = Number%10;
if (Number1 == Number2)
    System.Console.WriteLine("Обе цыфры числа равны");
else
    if (Number1 > Number2)
        System.Console.WriteLine(Number1);
    else
        System.Console.WriteLine(Number2);