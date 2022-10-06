// Дан массив, нужно сформировать новый массив из четных чисел. решение через МЕТОДЫ

// +1. Описать метод(функцию) получения псевдослучайного числа от min до max
// >2. Описать метод(функцию) создающую массив с указанным кол-вом элементов
// +3. Описать метод(функцию) заполнения массива псевдослучайными числами
// -4. Описать метод(функцию) распечатывания массив
//  5. Описать метод(функцию) нахождения четных чисел в массиве
//  6. Описать метод(функцию) финального решения

// +1. Описать метод(функцию) получения псевдослучайного числа от min до max
int GetIntValue(int min, int max)
{
    return new Random().Next(min, max);
}

// >2. Описать метод(функцию) создающую массив с указанным кол-вом элементов
int[] CreateArray(int size)     //создать массив по кол-ву
{
    return new int[size];
}

// +3. Описать метод(функцию) заполнения массива псевдослучайными числами
void Fill(int[] array)
{
    int size = array.Length;
    int i = 0;
    while (i < size)
    {
        array[i] = GetIntValue(1, 10);
        i++;
    }
}

// -4. Описать метод(функцию) распечатывания массив
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


//  5. Описать метод(функцию) нахождения четных чисел в массиве
int SearchNumberEvenElements(int[] array)
{
    int count = 0;
    int size = array.Length;
    int i = 0;
    while (i < size)
    {
        if (array[i] % 2 == 0)  //проверка на четность. Если при делении на ноль делится без остатка
        {
            count++;
        }
    }
    return count;
}

//  6. Описать метод(функцию) финального решения
int[] Final(int[] data, int count)
{
    int[] evenItems = new int[count];
    int pos = 0;                     //ввод переменной
    int i = 0;
    int size = data.Length;
    while(i < size)
    {
    if (data[i] % 2 == 0)           //если элемент в исходном массиве четный
    {
        evenItems[pos] = data[i];        //мы должны взять результирующий(evenItems), взять ту позицию(pos), которую мы определили и положить туда тот элемент, что оказался четным (source[i])
        pos++;                             //естественно, увеличиваем индекс
    }
    i++;
    }
    return evenItems;
}

int length = GetIntValue(10, 20);
int[] col = CreateArray(length);
Print(col);
Fill(col);
Print(col);
int count = SearchNumberEvenElements(col);
int[] result = Final(col, count);
Print(result);

