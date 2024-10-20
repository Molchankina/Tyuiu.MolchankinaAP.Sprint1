using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MolchankinaAP.Sprint1.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            double z = (Math.Pow(y, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(y, 2)) + 12);
            return z >= 0;
        }
    }
}
