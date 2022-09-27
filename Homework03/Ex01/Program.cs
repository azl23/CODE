// Напишите метод, который принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    System.Console.Write(message);
    string result = Console.ReadLine();
    return int.Parse(result);
}

// Реверс числа (123 => 321)
int NumberRev(int value)
{
    int res = 0;
    while (value > 0)
    {
        int a = value % 10;
        value = value / 10;
        res = res * 10 + a;
    }
    return res;
}

// Проверка на палиндром
bool СheckPalindrom(int value1, int value2)
{
    if (value1 == value2)
    {
        return true;
    }
    return false;
}

int numberOne = Prompt("Введите число ");
int numberTwo = NumberRev(numberOne);
bool isPalindrome = СheckPalindrom(numberOne, numberTwo);
if (isPalindrome)
{
    System.Console.WriteLine($"Число {numberOne} является палиндромом ");
}
else
{
    System.Console.WriteLine($"Число {numberOne} не является палиндропом ");
}