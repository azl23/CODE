// Определить, присутствует ли в заданном массиве, некоторое число

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
    array[index] = new Random().Next(1, 101);
    Console.Write(array[index] + " ");
    index++;
}

index = 0;
bool flage = true;

while (index < count)
{
    if (array[index] =/= find)
    {
   
    }
    else
    {
    
    }
    index++;
}

Console.WriteLine("\n Такой элемент есть ");
Console.WriteLine("\nТакого числа нет");
Console.WriteLine("\n END");