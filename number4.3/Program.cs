var r = new Random();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = r.Next(1,11);
    Console.WriteLine(array[i]);
}