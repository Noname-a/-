int a;
int sum = 0;

Console.WriteLine("Введите число:");
a = Convert.ToInt32(Console.ReadLine());

while (a > 0)
{
    sum = sum + a % 10;
    a /= 10;
}

Console.WriteLine("Сумма чисел: " + sum);