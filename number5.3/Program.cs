var r = new Random();
int[] a = new int[4];
int imin = 0;
int imax = 0;

for (int i = 1; i < a.Length; i++)
{
    a[i] = r.Next(0,100);
    Console.WriteLine(a[i]);
    if (a[i] < a[imin]) 
    imin = i;
    if (a[i] > a[imax]) 
    imax = i;
}
int b = imax - imin;
Console.Write("Разница между максимальным и минимальным: " + b);