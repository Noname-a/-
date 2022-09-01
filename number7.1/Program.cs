int n = 4; 
int m = 4; 
var r = new Random();
int[,] arr = new int[n, m];
Console.WriteLine("Массив:");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = r.Next(0, 99);
        Console.Write("{0} ", arr[i, j]);
    }
    Console.WriteLine();
}