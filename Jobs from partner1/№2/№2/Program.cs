int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
if ((y>x) || (x==y) || (x==0) || (y==0))
{
    Console.WriteLine("\nКоордината принадлежит указанной области");
}
else
{
    Console.WriteLine("\nКоордината не принадлежит указанной области");
}