using Tyuiu.MolchankinaAP.Sprint1.Task7.V13.Lib;
namespace Tyuiu.MolchankinaAP.Sprint1.Task7.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
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
            Console.WriteLine("Введите значение x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            double y = double.Parse(Console.ReadLine());
            bool isInShadedArea = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"({y}^2 - cos {x}^2 + 10)/({x}^2 - sin {y}^2 + 12) = {isInShadedArea}");
            Console.ReadKey();
        }
    }
}
