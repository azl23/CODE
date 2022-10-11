// Метод, который отдельно печатает двухмерную матрицу на экран и заполнять ее числами

void PrintArray(int[,] matr)           //метод принимает двухмерную таблицу чисел и печатает её на экран
{
    for (int i = 0; i < matr.GetLength(0); i++) //matrix.GetLength(0)-где 0 у нас будет 3
    {
        for (int j = 0; j < matr.GetLength(1); j++) //matrix.GetLength(1)- где 1 это наша цифра 4
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)           //метод заполнения матрици случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // Полуинтервал [1; 10)
        }
    }
}

int[,] matrix = new int[3, 4]; //инициализация
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);