// // Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве

int[] CreateArray(int size)
{
    return new int[size];
}

int GetIntValue(int min, int max)
{
    return new Random().Next(min, max);
}

void Fill(int[] array, int min, int max)
{
    int size = array.Length;
    int i = 0;
    while (i < size)
    {
        array[i] = GetIntValue(min, max);
        i++;
    }
}

void Print(int[] array)
{
    int i = 0;
    int size = array.Length;
    while (i < size)
    {
        Console.Write(array[i] + " ");
        i++;
    }
    Console.WriteLine();
}

int sumNegative(int[] array)
{
    int sum = 0;
    int length = array.Length;
    
    for ( int i = 0; i < length; i++)
    {
        if (array[i] < 0) 
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int sumPositive(int[] array)
{
    int sum = 0;
    int length = array.Length;
    
    for ( int i = 0; i < length; i++)
    {
        if (array[i] > 0) 
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] array = CreateArray(12);
Fill(array, -9, 10);
Print(array);
Console.WriteLine(sumPositive(array)); 
Console.WriteLine(sumNegative(array));

int[] Fill2(int[] arr1, int[] arr2)
{
    int length = array.Length;
    int leng2 = length / 2;
    int i = 0;
    while (i < leng2)
    {
        arr2[i] = arr1[i] * arr1[length -= 1];
        i++;
    }
    return arr2;
}




int[] array = CreateArray(12);
Fill(array, -10, 11);
Print(array);
