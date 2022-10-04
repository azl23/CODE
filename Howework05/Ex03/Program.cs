// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Ниже ваш массив из 4 случайных чисел");
Random rnd=new Random();
int[] array=new int[4];
int summ=0;
int index_max=0;
int index_min=0;
for (int i=0;i<array.Length;i++)
{
    array[i]=rnd.Next(1,100);
    Console.WriteLine(array[i]);
    if (array[i]>array[index_max]) 
    {index_max=i;}
    else
    {
        if (array[i]<array[index_min])
        {index_min=i;}
    }
}
Console.WriteLine($"Максимальный элемент {array[index_max]} Минимальный элемент {array[index_min]} разница между ними {array[index_max]-array[index_min]}");
