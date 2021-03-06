static int leap(int year)
{
    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
    {
        return 1;
    }
    else
    {
        return 0;
    }
}
Console.WriteLine("Задайте дату по Григорианскому календарю");
Console.WriteLine("День: ");
int day = int.Parse(Console.ReadLine());
Console.WriteLine("Месяц: ");
int month = int.Parse(Console.ReadLine());
Console.WriteLine("Год: ");
int year = int.Parse(Console.ReadLine());
int[,] date = new int[2, 12] { { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }, { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 } };

if (day >= date[leap(year), month - 1])
{
    Console.WriteLine($"Дата {day}.{month}.{year} некоректна!");
}
else
{
    Console.WriteLine($"Дата {day}.{month}.{year} коректна!");
}

var dt = new DateTime(year, month, day);
var bdt = new DateTime(year, 1, 1);
int after;
int before;
after = (dt - bdt).Days + 1;

if (leap(year) == 0)
{
    before = 365- after;
}
else
{
    before = 366 - after;
}
Console.WriteLine($"Сейчас {after}-й день в году.");
Console.WriteLine($"До конца года осталось {before} дней.");
