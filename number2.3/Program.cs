int a;

Console.WriteLine("Введите номер дня недели:");
a = Convert.ToInt32(Console.ReadLine());

if (a < 6)
{
    Console.WriteLine(a + " Это рабочий день");
}
else if (a == 6)
{
    Console.WriteLine(a + " Это суббота");
}
else if (a == 7)
{
    Console.WriteLine(a + " Это воскресенье");
}