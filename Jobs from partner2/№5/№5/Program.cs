int r;
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    r = i * i;
    if (r > n)
    {
        Console.WriteLine($"Первое число, квадрат которого больше n: {i}");
        break;
    }
}