int n;
int[] arr = new int[10];
for (int i = 0; i < arr.Length; i++)
{
    n = new Random().Next(1, 100);
    arr[i] = n;
    Console.WriteLine(arr[i]);
}
var even = arr.Where((element, index)=>index%2 !=0);
Console.WriteLine();
Console.WriteLine(even.Count());
Console.WriteLine();
Console.WriteLine(even.Sum());