// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Ниже ваш массив из 4 случайных чисел");
Random rnd=new Random();
int[] array=new int[4];
int summ=0;
for (int i=0;i<array.Length;i++)
{
    array[i]=rnd.Next(-100,100);
    Console.WriteLine(array[i]);
    if (i%2!=0) 
    {
        summ=summ+array[i];
    }
}
Console.WriteLine($"Сумма элементов массива на нечетных позициях равняется {summ}");