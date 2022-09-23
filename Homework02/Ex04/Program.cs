// Напишите программу, которая принимает на вход семь чисел, и находит их среднее арифметическое
// 1 2 3 4 5 6 7-> 4
// 10 20 30 40 50 60 70 -> 40

int[] array = {1, 2, 3, 4, 5, 6, 7};
int size = array.Length;
int index = 0;
int summ = 0;

while(index < array.Length)
{
    summ = summ + array[index];
    index++;
}

int avg = summ / size;
System.Console.WriteLine(avg);
