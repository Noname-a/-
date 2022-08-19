Console.WriteLine("Введите координаты точки A: ");
int ax = int.Parse(Console.ReadLine());
int ay = int.Parse(Console.ReadLine());
int az = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
int bx = int.Parse(Console.ReadLine());
int by = int.Parse(Console.ReadLine());
int bz = int.Parse(Console.ReadLine());

Console.WriteLine("Разность точек: ");
Console.WriteLine(ax-bx);
Console.WriteLine(ay-by);
Console.WriteLine(az-bz);
Console.WriteLine("Расстояние между точками: ");

double ABC = Math.Sqrt(Math.Pow(ax-bx,2) + Math.Pow(ay-by,2) + Math.Pow(az-bz,2));

Console.WriteLine(ABC);

