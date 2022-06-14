Console.WriteLine("Введите площадь: ");
int n = int.Parse(Console.ReadLine());
for (int x = 1; x <= 5; x++)
{
    int a = x * x;
    for (int y = 1; y <= 5; y++)
    {
        int b = y * y;
        for (int z = 1; z <= 5; z++)
        {
            int c = z * z;
            int sum = a + b;
            double S = (x * y) / 2;
            if (sum == c)
            {
                if (n > S)
                {
                    Console.WriteLine($"Стороны треугольника a={x} b={y} c={z} ");
                    Console.WriteLine($"Площадь треугольника S={S} ");
                }
            }
        }
    }
}
