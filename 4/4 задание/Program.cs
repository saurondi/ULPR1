Console.WriteLine("Привет, до какого числа будем гадать?");
int n = int.Parse(Console.ReadLine());
int k;
int c = 0;
Random rand = new Random();
int num = rand.Next(1,n);
int error = rand.Next(5, 10);
int error2 = error;
Console.WriteLine($"У вас есть {error} попыток!");
Console.WriteLine("Пробуйте угадать!");
for (int i = 0; i < error2; i++)
{
    k = int.Parse(Console.ReadLine());
    if (k < num)
    {
        Console.WriteLine("Число меньше загаданного!");
        error = error - 1;
        Console.WriteLine($"Пробуйте дальше у вас осталось: {error} попыток!");
    }
    if (k > num)
    {
        Console.WriteLine("Число больше загаданного!");
        error = error - 1;
        Console.WriteLine($"Пробуйте дальше у вас осталось: {error} попыток!");
    }
    if (k == num)
    {
        Console.WriteLine($"Вы угадали число - {num}!");
        break;
    }
    c++;
    if (c == error2)
    {
        Console.WriteLine($"Увы у вас не получилось угадать число. Им было - {num} :((((");
        break;
    }
}
