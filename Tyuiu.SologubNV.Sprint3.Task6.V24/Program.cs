using Tyuiu.SologubNV.Sprint3.Task6.V24.Lib;
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
        WriteLine("* Задание #7                                                              *");
        WriteLine("* Вариант #24                                                             *");
        WriteLine("* Выполнил: Сологуб Николай Витальевич | ИБКСб-26-1                       *");
        WriteLine("***************************************************************************");
        WriteLine("* УСЛОВИЕ;                                                                *");
        WriteLine("* Напишите программу, которая выводит таблицу значений функции:           *");
        WriteLine("*             sin(x)                                                      *");
        WriteLine("*        F(x)=------ - sin(x)*2 -2x                                       *");
        WriteLine("*              x+1.2                                                      *");
        WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5;5] с шагом 1. *");
        WriteLine("*Произвести проверку деленияна ноль.При делении наноль вернуть значение 0.*");
        WriteLine("***************************************************************************");
        WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        WriteLine("***************************************************************************");
        int sv = -5;
        int ev = 5;
        WriteLine($"Старт Шага = {sv}");
        WriteLine($"Конец шага= {ev}");
        int len = ds.GetMassFunction(sv, ev).Length;
        double[] arr = new double[len];
        arr = ds.GetMassFunction(sv, ev);
        WriteLine("***************************************************************************");
        WriteLine("* РЕЗУЛЬТАТ                                                               *");
        WriteLine("***************************************************************************");
        WriteLine("+------------+-----------+");
        WriteLine("|     X      |   f(x)    |");
        WriteLine("+------------+-----------+");
        for(int i = 0; i <= len - 1; i++)
        {
            int x = sv + i;
            WriteLine($"|   {sv+i,4}     |  {arr[i],6:f2}   |");
        }
        WriteLine("+------------+-----------+");
        ReadLine();
    }
}