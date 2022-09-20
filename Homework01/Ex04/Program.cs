// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int start = 2;
int n = 20;

while(start <= n)
{
    System.Console.WriteLine(start);
    start = start + 2;
}