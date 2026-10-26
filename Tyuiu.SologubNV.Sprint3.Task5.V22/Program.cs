using Tyuiu.SologubNV.Sprint3.Task5.V22.Lib;
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
        WriteLine("* Задание #4                                                              *");
        WriteLine("* Вариант #29                                                             *");
        WriteLine("* Выполнил: Сологуб Николай Витальевич | ИБКСб-26-1                       *");
        WriteLine("***************************************************************************");
        WriteLine("* УСЛОВИЕ;                                                                *");
        WriteLine("*        3   12                                                           *");
        WriteLine("*   S =  E * E(x^3 * sin(k))+2 при x=2                                    *");
        WriteLine("*       i=1 k=1                                                           *");
        WriteLine("*                                                                         *");
        WriteLine("***************************************************************************");
        WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        WriteLine("***************************************************************************");
        int x = 2;
        int sv = 1;
        int ev = 3;
        int sv2 = 1;
        int ev2 = 12;
        WriteLine($"Переменная X = {x}");
        WriteLine($"Старт Шага первой суммы ряда = {sv}");
        WriteLine($"Конец Шага первой суммы ряда= {ev}");
        WriteLine($"Старт Шага второй суммы ряда = {sv2}");
        WriteLine($"Конец Шага второй суммы ряда= {ev2}");
        WriteLine("***************************************************************************");
        WriteLine("* РЕЗУЛЬТАТ                                                               *");
        WriteLine("***************************************************************************");
        WriteLine($"Сумма ряда = {ds.GetSumSumSeries(x,sv,sv2, ev,ev2)}");
        ReadLine();
    }
}