using Tyuiu.SologubNV.Sprint3.Task3.V28.Lib;
using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Title = "Спринт #3 | Выполнил: Сологуб Н.В | ИБКСб-26-1";
        WriteLine("***************************************************************************");
        WriteLine("* Спринт #3                                                               *");
        WriteLine("* Тема: Оператор цикла do-while                                           *");
        WriteLine("* Задание #3                                                              *");
        WriteLine("* Вариант #28                                                             *");
        WriteLine("* Выполнил: Сологуб Николай Витальевич | ИБКСб-26-1                       *");
        WriteLine("***************************************************************************");
        WriteLine("* УСЛОВИЕ;                                                                *");
        WriteLine("* Используя цикл foreach заменить цифры на букву r в строке:              *");
        WriteLine("* f35hyt t4j 3gkg45                                                       *");
        WriteLine("*                                                                         *");
        WriteLine("*                                                                         *");
        WriteLine("***************************************************************************");
        WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        WriteLine("***************************************************************************");
        string a = "f35hyt t4j 3gkg45";
        char sv = 'r';
        WriteLine($"Исходная строка = {a}");
        WriteLine($"Исходный символ = {sv}");
        WriteLine("***************************************************************************");
        WriteLine("* РЕЗУЛЬТАТ                                                               *");
        WriteLine("***************************************************************************");
        WriteLine($"Сумма ряда = {ds.ReplaceNumOnChar(a, sv)}");
        ReadLine();
    }
}