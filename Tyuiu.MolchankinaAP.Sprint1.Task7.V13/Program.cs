using Tyuiu.MolchankinaAP.Sprint1.Task7.V13.Lib;
namespace Tyuiu.MolchankinaAP.Sprint1.Task7.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Молчанкина А. П. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Формула                                                           *");
            Console.WriteLine("* куба.                                                                   *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Молчанкина Ангелина Павловна | СМАРТб-24-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
            Console.WriteLine("*      y^2 - cos x^2 + 10                                                 *");
            Console.WriteLine("* z = --------------------                                                *");
            Console.WriteLine("*      x^2 - sin y^2 + 12                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x;
            Console.WriteLine("Переменная x:");
            x = Convert.ToInt32(Console.ReadLine());
            int y;
            Console.WriteLine("Переменная y:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("z = (y^2 - cos x^2 + 10)/(x^2 - sin y^2 + 12)" + ds.CheckDotInShadedArea(x, y));
            Console.ReadKey();
        }
    }
}
