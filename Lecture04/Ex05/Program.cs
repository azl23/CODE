﻿// Метод, который принимает число, факториал которого возвращает
//(метод принимает какое-то число и возвращает факториа какого-то числа)

double Factorial(int n)
{
    if (n == 1) return 1;  //если какое-то число равен 1, то выводить единицу. 1! = 1 и 0! = 1
    else return n * Factorial(n - 1); //если нет, то число умножаем на это чило - 1, пока число не будет 1. и возвращаем это число
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}



