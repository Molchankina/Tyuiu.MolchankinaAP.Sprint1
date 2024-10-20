using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MolchankinaAP.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            string kStr = k.ToString();
            if (kStr.Length < 3)
            {
                throw new ArgumentException("Число должно содержать как минимум 3 цифры.");
            }
            char thirdFromEnd = kStr[kStr.Length - 3];
            return (int)char.GetNumericValue(thirdFromEnd);
        }
    }
}
