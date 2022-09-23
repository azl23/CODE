// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string messege)
{
    System.Console.Write(messege);           //Ввыводит сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат
}
int dayNumber = Prompt("Введите число от 1 до 7 и программа покажет является ли этот день выходным ");

if(dayNumber == 1)
{
    Console.WriteLine("Нет");
}

if (dayNumber == 2)
{
    Console.WriteLine("Нет");
}
if (dayNumber == 3)
{
    Console.WriteLine("Нет");
}
if (dayNumber == 4)
{
    Console.WriteLine("Нет");
}
if (dayNumber == 5)
{
    Console.WriteLine("Нет");
}
if (dayNumber == 6)
{
    Console.WriteLine("Да");
}
if (dayNumber == 7)
{
    Console.WriteLine("Да");
}
