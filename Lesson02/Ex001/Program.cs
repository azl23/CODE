// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все четные числа от 1 до N
// 5 -> 2,4
// 8 -> 2, 4, 6, 8

int start = 2;
Console.Write("Введите n ");
int n = Convert.ToInt32(Console.ReadLine()); //читает вывод

while(start <= n )
{
    Console.WriteLine(start + "  ");
    start = start + 2;
}