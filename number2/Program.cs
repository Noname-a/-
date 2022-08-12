int a, b, c;
int mmax;

Console.WriteLine("Введите три числа:");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    mmax = a;
}
else
{
    mmax = b;
}

if (b > c)
{
    mmax = b;
}
else
{
    mmax = c;
}

if (a > c)
{
    mmax = a;
}
else
{
    mmax = c;
}

Console.WriteLine(mmax);