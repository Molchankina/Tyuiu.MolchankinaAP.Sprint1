using Tyuiu.MolchankinaAP.Sprint1.Task6.V12.Lib;
namespace Tyuiu.MolchankinaAP.Sprint1.Task6.V12
{
    internal class Program //Написать программу: пользователь вводит текст. Проверить, что последнее слово строки входит в нее еще раз.
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Молчанкина А. П. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Формула                                                           *");
            Console.WriteLine("* куба.                                                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Молчанкина Ангелина Павловна | СМАРТб-24-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Пользователь вводит текст. Проверить, что последнее слово строки входит *");
            Console.WriteLine("* в нее еще раз.                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите текст: ");
            string input = Console.ReadLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            bool isRepeated = ds.CheckLastWordRepetiton(input);
            if (isRepeated)
            {
                Console.WriteLine("Последнее слово встречается в строке еще раз.");
            }
            else
            {
                Console.WriteLine("Последнее слово не встречается в строке еще раз.");
            }
            Console.ReadKey();
        }
    }
}
