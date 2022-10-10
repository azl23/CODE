// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].

// 1. Создать массив
// 2. Заполнить массив нужными числами
// 3. Печать массива
// 4. Финал

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

// 4. Финал
int Search(int[] array, int FindMin, int FindMax)
{
    int size = array.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] >= FindMin && array[i] <= FindMax)
        {
            count++;
        }
    }
    return count;
}

int[] arr = Create(12);  //объявляем массив
//Console.WriteLine(Print(arr));
Fillint(arr, 1, 200);
Console.WriteLine(Print(arr));
Console.WriteLine(Search(arr, 10, 99));
