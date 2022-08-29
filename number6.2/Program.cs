Console.WriteLine("Введите k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k2: ");
int k2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b2: ");
int b2 = int.Parse(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");

