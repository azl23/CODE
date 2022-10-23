//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько чисел будем вводить?:");
int M = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[M];
int i = 0;
while (i < arr.Length)
{
    Console.WriteLine($"Введите {i + 1}-е число:");
    arr[i] = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    i++;
}
Console.WriteLine("Ваш массив:");
i = 0;
while (i < arr.Length)
{
    Console.Write($" {arr[i]}");
    i++;
}
Console.WriteLine();
i = 0;
int count = 0;
while (i < arr.Length)
{
    if (arr[i] > 0)
    { count++; }
    i++;
}
Console.WriteLine($"В вашем массиве {count} чисел больше 0");