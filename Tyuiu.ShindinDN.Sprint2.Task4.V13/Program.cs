﻿using Tyuiu.ShindinDN.Sprint2.Task4.V13.Lib;

namespace Tyuiu.ShindinDN.Sprint2.Task4.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Шиндин Д. Н. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Шиндин Денис Николаевич | ИСТНб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит            *");
            Console.WriteLine("* значение переменных x, y с клавиатуры                                   *");
            Console.WriteLine("* если   ___                                                              *");
            Console.WriteLine("*       | x * 3 > y * 2 - 20, то z = x + 10 * y - (1 / x)                 *");
            Console.WriteLine("* иначе (x * x + cos(y * y) + 13) / (y * y - sin(y * y) + 9)              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите знечение X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x,y));
        }
    }
}
