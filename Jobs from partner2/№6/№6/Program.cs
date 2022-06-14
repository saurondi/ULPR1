int n = int.Parse(Console.ReadLine());
Console.WriteLine();
for (int i = 10; i < 100; i++)
{
    if(i%n == 0)
    {
        Console.WriteLine(i+ "");
        
    }
}
Console.WriteLine();
for (int i = 10; i < 100; i++)
{
    int num1 = i % 10;
    int num2 = i / 10;
    if (num1 == n || num2 == n)
    {
        Console.WriteLine(i + "");
    }
}