// Рекурсия с числами Фибиначчи

//f(1) = 1
//f(2) = 1
//f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)  //метод для Фибиначчи
{
    if(n == 1 || n == 2) return 1;  //если n = 1 или n = 2, то возвращаем 1
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}"); //выведет "f(n) = числа Фибиначчи"
}