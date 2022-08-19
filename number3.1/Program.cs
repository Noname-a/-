int num, rem, sum = 0, temp = 0;

Console.WriteLine("Введите пятизначное число:");
num = Convert.ToInt32(Console.ReadLine());
temp = num;

while (num > 0)
{
    rem = num % 10; 
    num = num / 10; 
    sum = sum * 10 + rem;
}
Console.WriteLine("Перевернутое число: " + sum);

if (temp == sum)
{
    Console.WriteLine("Число является палиндромом");
}
else 
{
    Console.WriteLine("Число не является палиндромом");
}