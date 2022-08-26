var r = new Random();
int[] array = new int[3];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = r.Next(99,1000);
    Console.WriteLine(array[i]);
    if ((array[i] % 2) == 0)
        count++;
}
Console.Write("Количество четных чисел в массиве: "+count);