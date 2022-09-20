// Напишите программу, которая выводит случное число из отрезка Х[10, 99] и показывает наибольшую из них
// 78 -> 8
// 12 -> 2

Console.Clear();
int n = new Random().Next(10, 100);
Console.WriteLine("Здравствуй, дорогой пользователь! ");
Console.WriteLine("Загадано число ");
Console.WriteLine(n);
int a = n / 10;
int b = n / 10;

System.Console.WriteLine("Максимальная цифра: ");
if (a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}

