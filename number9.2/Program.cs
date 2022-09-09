Console.Write("Введите a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите b: ");
int b = int.Parse(Console.ReadLine());

static int RecursiveMethod(int a, int b)
{
    Console.WriteLine(a);
    if (a == b)
    {
        return a;
    }
    else 
    {
        return a + RecursiveMethod(a + 1, b); 
    }
}
Console.WriteLine($"Сумма = {RecursiveMethod(a, b)}");

