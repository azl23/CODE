// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Ниже ваш массив из 4 случайных чисел");
Random rnd=new Random();
int[] array=new int[4];
int even=0;
for (int i=0;i<array.Length;i++)
{
    array[i]=rnd.Next(100,1000);
    Console.WriteLine(array[i]);
    if (array[i]%2==0) 
    {
        even++;
    }
}
Console.WriteLine($"В массиве {even} четных числа");
