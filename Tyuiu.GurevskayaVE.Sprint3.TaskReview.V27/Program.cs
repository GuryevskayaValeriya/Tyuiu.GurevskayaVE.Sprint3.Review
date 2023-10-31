using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GurevskayaVE.Sprint3.TaskReview.V27.Lib;

namespace Tyuiu.GurevskayaVE.Sprint3.TaskReview.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Гурьевская В.Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: SprintReview                                                      *");
            Console.WriteLine("* Задание #Review                                                         *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнила: Гурьевская В.Е. | ПКТб-23-2                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("* f(x) = cos(x)/(x+1) - cos(x)*1.3 +3x                                    *");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5;5]            *");
            Console.WriteLine("* с шагом 1. Произвести проверку деления на ноль. При делении на ноль     *");
            Console.WriteLine("* вернуть значение ноль. Округлить до 2 знаков после запятой.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();


            int startValue = -5;
            int stopValue = 5;


            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.Calc(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.Calc(startValue, stopValue);



            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|   x      |    f(x)   |");
            Console.WriteLine("+----------+-----------+");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     |   {1, 6:f2}  |", startValue, valueArray[i]);
                startValue++;
            }

            Console.WriteLine("+----------+-----------+");




            Console.ReadKey();
        }
    }
}
