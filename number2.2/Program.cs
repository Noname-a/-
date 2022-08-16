int a;

Console.WriteLine("Введите число:");
a = Convert.ToInt32(Console.ReadLine());

if (a > 99)
{
    int b = (a % 100) % 10;
    Console.WriteLine(b);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
