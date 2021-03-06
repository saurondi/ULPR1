static int leap(int year)
{
    if (year%4==0 && year%100 != 0 || year%400 == 0)
    {
        return 1;
    }
    else
    {
        return 0;
    }
}
Console.WriteLine("Задайте дату по Юлианскому календарю");
Console.WriteLine("День: ");
int day = int.Parse(Console.ReadLine());
Console.WriteLine("Месяц: ");
int month = int.Parse(Console.ReadLine());
Console.WriteLine("Год: ");
int year = int.Parse(Console.ReadLine());
int[ ,] date = new int[2, 12] { {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }, { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 } };
int c = 0;
for (int i = 325; i <= year; i++)
{
    if ((i % 100 == 0) && (i % 400 != 0))
    {
        c++;
    }
}
day += c;
if (day > date[leap(year), month - 1])
{
    day-=date[leap(year),month-1]-1;
    month++;
    if (month > 12)
    {
        month = month % 12;
        year++;
    }
}
Console.WriteLine("По Григорианскому календарю сейчас: ");
Console.WriteLine($"День: {day}");
Console.WriteLine($"Месяц: {month}");
Console.WriteLine($"Год: {year}");