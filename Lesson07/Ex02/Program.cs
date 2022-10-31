// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементов массива.

double[] GetArr(int n)
{
    double[] arr = new double[n];
    for (int i = 0; i < 5; i++)
    {
        arr[i] = new Random().Next(0, 100) / 10.0; // [0, 10.0)
    }
    return arr;
}

System.Console.WriteLine(String.Join(' ', GetArr(5)));