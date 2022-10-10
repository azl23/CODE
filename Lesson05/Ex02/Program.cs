//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

// 1. Задать массив
// 2. Заполнить массив нужными числами
// 3. Печать массива
// 4. Сумма максимальных элементов массива
// 5. Сумма минимальных элементов массива

// 1. Создать массив
int[] Create(int len)     //создать массив по кол-ву
{
    return new int[len];
}

// 2. Заполнить массив нужными числами
void Fillint(int[] array, int min, int max)
{
    int size = array.Length;      //везде далее писать array.Length не оч хорошо писать
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

// 3. Печать массива
string Print(int[] array)     //создать массив по кол-ву
{
    //return "[" + String.Join(', ',array) + "]";  //String.Join - берет на вход массив и разделяет его, в данном случае ","
    string result = "[";

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) result = result + array[i] + ", ";
        else result = result + array[i];
    }
    return result + "]";
}

// 4. Сумма максимальных элементов массива
int SummPositive(int[] array)
{
    int sum = 0;
    int size = array.Length;
    for(int i = 0; i < size; i++)
    {
        if(array[i] > 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

// 5. Сумма минимальных элементов массива
int SummNegative(int[] array)
{
    int sum = 0;
    int size = array.Length;
    for(int i = 0; i < size; i++)
    {
        if(array[i] < 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] arr = Create(12);
//Console.WriteLine(Print(arr));
Fillint(arr, -9, 9);
Console.WriteLine(Print(arr));
Console.WriteLine(SummPositive(arr));
Console.WriteLine(SummNegative(arr));