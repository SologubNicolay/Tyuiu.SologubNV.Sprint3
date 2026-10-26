using Tyuiu.SologubNV.Sprint3.Task2.V29.Lib;
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
        WriteLine("* Задание #2                                                              *");
        WriteLine("* Вариант #29                                                             *");
        WriteLine("* Выполнил: Сологуб Николай Витальевич | ИБКСб-26-1                       *");
        WriteLine("***************************************************************************");
        WriteLine("* УСЛОВИЕ;                                                                *");
        WriteLine("* Написать программу используя цикл do-while, которая вычисляет           *");
        WriteLine("* сумму ряда по формуле, при a=0,5                                        *");
        WriteLine("*        18                                                               *");
        WriteLine("*   S =  E(a^k+0.25)*cos(k)                                               *");
        WriteLine("*       k=1                                                               *");
        WriteLine("***************************************************************************");
        WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        WriteLine("***************************************************************************");
        double a = 0.5;
        int sv = 1;
        int ev = 18;
        WriteLine($"Переменная a = {a}");
        WriteLine($"Старт Шага = {sv}");
        WriteLine($"Конец Шага = {ev}");
        WriteLine("***************************************************************************");
        WriteLine("* РЕЗУЛЬТАТ                                                               *");
        WriteLine("***************************************************************************");
        WriteLine($"Сумма ряда = {ds.GetSumSeries(a, sv, ev)}");
        ReadLine();
    }
}