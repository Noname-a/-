Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());
int AB = a;

for (int i = 1; i < b; i++)
	{
		AB *= a;
	}
Console.WriteLine("Число A в степени B: " + AB);