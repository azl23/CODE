﻿// Определить, присутствует ли в заданном массиве, некоторое число

Console.Clear();
int count = 10;
int[] array = new int[count];
int find = new Random().Next(1, 21);
int index = 0;
Console.Write("Ищем = ");
Console.WriteLine(find);
Console.Write("Массив: ");

while (index < count)
{
    array[index] = new Random().Next(1, 22);
    Console.WriteLine(array[index] + " ");
    index++;
}

index = 0;
bool elementFind = false;

while (index < count)
{
    if (array[index] == find)
    {
        elementFind = true;
    }
    else
    {

    }
    index += 1;
}
if (elementFind == true)
{
    Console.WriteLine("\nТакой элемент есть ");
}
else
{
    Console.WriteLine("\nТакого элемента нет");
}

Console.WriteLine("\nEND");


