int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int x = Convert.ToInt32(Console.ReadLine());
double y = x*(Math.PI/180.0);
double s = a * b * Math.Sin(y);
Console.WriteLine(s);