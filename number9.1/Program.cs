Console.WriteLine("Введите число больше 0: ");
int i = int.Parse(Console.ReadLine());

void RecursionNumbers(int i)
{
    if (i == 1)
    {
        Console.Write($" {i}");
    }
    else
    {
        Console.Write($" {i}");
        i--;
        RecursionNumbers(i);
    }
}

RecursionNumbers(i);