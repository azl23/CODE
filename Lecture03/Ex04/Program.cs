// Алгоритм сортировки максимального/минимального
//1. Найти позицию минимального элемента в неотсортированном массиве.
//2. Произвести обмен этого значения со значением первой неотсортированной позиции
//3. Повторять пока есть не отсортированные элементы

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)      //метод вывода массива на экран
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)              //метод упорядочивания нашего массива
{
    for (int i = 0; i < array.Length - 1; i++)           //ищем минимальный элемент
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)  //ищем максимальный элемент
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr); //команда распечатать наш массив
SelectionSort(arr); //команда вызова упорядочивание массива

PrintArray(arr);

