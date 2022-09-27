// Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

void CubNumber(int number)
{
    for(int i = 1; i <= number; i++)
    {
        Console.WriteLine(i * i * i);;
    }
}

int message = Prompt("Введите число ");
Console.WriteLine($"Таблица кубов чисел от 1 {message} ");
CubNumber(message); 