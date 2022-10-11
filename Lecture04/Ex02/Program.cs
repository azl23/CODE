// Определение на числах

int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++) //matrix.GetLength(0)-где 0 у нас будет 3
{
    for (int j = 0; j < matrix.GetLength(1); j++) //matrix.GetLength(1)- где 1 это наша цифра 4
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}