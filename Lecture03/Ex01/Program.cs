/// Вид 1

void Method1()
{
    Console.WriteLine("Автор ...");
}
//Method1();                                                      // как вызывается метод

/// Вид 2. Метод ничего не возвращает, но принимает какие-то аргументы

void Method2(string msg)                                         //msg - какие-то аргументы
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");                               // вызываем метод с текстом сообщения

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", count: 4);
//Method21(count: 4, msg: "новый текст");

/// Вид 3. Метод что-то возвращвет, но ничего не принимает

int Method3()                                                   // аргументы он никакие не принимает
{
    return DateTime.Now.Year;                                   //текущий год
}
int year = Method3();    //использовать индификатор переменной(тут int year) и через оператор присваивания положить нужное значение
//Console.WriteLine(year); //использовать ту переменную и значение, которое нам вернул метод


//Вид 4. Метод, который что-то принимает и что-то возвращает

//string Method4(int count, string text)        //строку "text" компоновать "count" раз
//{
//    int i = 0;
//    string result = String.Empty;          //переменная, куда мы будем класть результат конечный. String.Empty - пестая строка
//    {
//        while (i < count)
//        {
//            result = result + text;
//            i++;
//        }
//        return result;                    //возвращаем результат, который ожидаем из метода
//    }
//}
//string res = Method4(10, "z"); //чтоб вызвать метод, создаем нужную переменную (string res).10 - у нас "count", ASDF - text
//Console.WriteLine(res); 

//ЧЕРЕЗ ЦИКЛ for
string Method4(int count, string text)        //строку "text" компоновать "count" раз
{
    string result = String.Empty;          //переменная, куда мы будем класть результат конечный. String.Empty - пестая строка
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;                    //возвращаем результат, который ожидаем из метода
}
string res = Method4(10, "z"); //чтоб вызвать метод, создаем нужную переменную (string res).10 - у нас "count", ASDF - text
Console.WriteLine(res);
