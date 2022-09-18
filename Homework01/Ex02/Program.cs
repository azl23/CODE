// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int numberOne = 22;
int numberTwo = 3;
int numberThree = 9;

int max = numberOne;

if(numberTwo > max)
{
    max = numberTwo;
}
if(numberThree > max)
{
    max = numberThree;
}

Console.WriteLine(max);