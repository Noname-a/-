var r = new Random();
int[] a = new int[4];
int sum = 0;
for (int i = 0; i < a.Length; i++)
{
    a[i] = r.Next(0,11);
    Console.WriteLine(a[i]);
    if (i % 2 == 1)
        sum += a[i];
}

Console.Write("Сумма нечетных чисел: "+sum);