Console.WriteLine("Сколько яблок сорвал первый человек?");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Сколько было людей?");
int m = int.Parse(Console.ReadLine());
int temp = m - 1;
int[] mass = new int[m + 1];
mass[0] = y;
for (int i = 0; i < m; i++)
{

    for (int j = 0; j < m; j++)
    {
        if (j != i)
        {
            mass[j] = mass[j] + mass[i] / temp;
        }
    }
    mass[i] = 0;
}
Console.WriteLine("У людей осталось столько яблок ");
for (int h = 0; h < m; h++)
{
    Console.WriteLine(mass[h]);
}