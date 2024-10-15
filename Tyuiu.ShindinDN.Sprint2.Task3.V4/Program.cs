using Tyuiu.ShindinDN.Sprint2.Task3.V4.Lib;

namespace Tyuiu.ShindinDN.Sprint2.Task3.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Шиндин Д. Н. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Шиндин Денис Николаевич | ИСТНб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y      *");
            Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь           *");
            Console.WriteLine("* вводит значение переменной X с клавиатуры.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*        (x + 1)^x                                                        *");
            Console.WriteLine("*   x + ----------- , если x > 1                                          *");
            Console.WriteLine("*        (x - 1)^x                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*      x^2 + cos(x^2)                                                     *");
            Console.WriteLine("*   --------------------- , если x = 0                                    *");
            Console.WriteLine("*    x^2 - sin(x^2) + 12                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*            1                                                            *");
            Console.WriteLine("*     (x - -----)^x , если -8 < x < 0                                     *");
            Console.WriteLine("*           x^2                                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                1                                                        *");
            Console.WriteLine("*     x + 10x - --- , если x < -8                                         *");
            Console.WriteLine("*                x                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x));

            Console.ReadLine();
        }
    }
}
