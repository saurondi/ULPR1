int sum = 0;
string chisla = Console .ReadLine();
int[] masSymb = new int[chisla.Length];
for (int i = 0; i < chisla.Length; i++)
{
    sum += Convert.ToInt32(chisla[i] - '0');
}
Console.WriteLine(sum);