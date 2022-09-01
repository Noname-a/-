Console.Write("Введите строку:");
int a = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец:");
int b = Convert.ToInt32(Console.ReadLine()) - 1;
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
if (a < 0 | a > arr.GetLength(0) - 1 | b < 0 | b > arr.GetLength(1) - 1)
{
    Console.WriteLine("Элементa не существует");
}
else
{
    Console.WriteLine("Значение элемента массива: {0}", arr[a, b]);
}