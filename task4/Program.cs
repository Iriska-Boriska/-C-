//По заданному с клавиатуры номеру дня недели вывести его название
Console.Clear();

string [] Week = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
System.Console.Write ("Введи номер дня недели: ");
int DayNumber = Convert.ToInt32 (Console.Read ()); //Почему если я ввожу 1, то в DayNumber записывается 49??
int IDDayNumber = Convert.ToInt32 (DayNumber-49); // -1 что бы ID правильный показывал, -48 не знаю почему (см комент строки выше)
string DayWeek = Week [IDDayNumber];
System.Console.WriteLine (DayWeek);

/*   // !!Я не понимаю, почему здесь какую цифру не вводи везде идёт переход к else??
System.Console.WriteLine ("Введи номер дня в неделе: ");
int DayNumber = Convert.ToInt32 (Console.Read ());
if (DayNumber == 1)
{
    System.Console.WriteLine("Понедельник");
}
else
{
    if (DayNumber == 2)
    {
         System.Console.WriteLine("Вторник");
    }
    else
    {
        if (DayNumber == 3)
        {
            System.Console.WriteLine("Среда");
        }
        else
        {
            if (DayNumber == 4)
            {
                System.Console.WriteLine("Четверг");
            }
            else
            {
                if (DayNumber == 5)
                {
                    System.Console.WriteLine("Пятница");
                }
                else
                {
                    if (DayNumber == 6)
                    {
                        System.Console.WriteLine("Суббота");
                    }
                    else
                    {
                       if (DayNumber == 7)
                        {
                            System.Console.WriteLine("Воскресенье");
                        }
                        else
                        {
                            System.Console.WriteLine("Введённое число не входит в диапазон 1-7");
                        };
                    };
                };
            };
        };
    };
};
*/