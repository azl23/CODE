// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные,
// и наоборот.

// 1. Создать массив
// 2. Заполнить массив
// 3. Печать массива
// 4. Перевернуть значения

// 1. Создать массив
int[] Create(int len)     //создать массив по кол-ву
{
    return new int[len];
}

// 2. Заполнить массив нужными числами
void Fill(int[] array, int min, int max)
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

// 4. 
int[] Perevorot(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

int[] arr = Create(12);
Fill(arr, -9, 9);
Console.WriteLine(Print(arr));
Console.WriteLine(Print(Perevorot(arr)));





