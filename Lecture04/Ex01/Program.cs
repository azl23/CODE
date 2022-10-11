// Определение таблицы строк.

string[,] table = new string[2, 5]; // 2 и 5 - размер массива, а не значения. Индексы идут с 0
//String.Empty - инициализация строк
//table[0, 0]   table[0, 1] table[0, 2]     table[0, 3]     table[0, 4] 
//table[1, 0]   table[1, 1] table[1, 2]     table[1, 3]     table[1, 4] 

table[1, 2] = "Слово "; // Где 1- позиция строк, 2- позиция столбцов

for(int rows = 0; rows < 2; rows++) //где 2 - позиция строк
{
    for(int columns = 0; columns < 5; columns++) //где 5 - позиция столбцов
    {
    Console.WriteLine($"-{table[rows, columns]}-");
    }
}


