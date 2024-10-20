using Tyuiu.MolchankinaAP.Sprint1.Task7.V13.Lib;
namespace Tyuiu.MolchankinaAP.Sprint1.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.5;
            double y = 2.0;
            bool expectedResult = true;

            bool actualResult = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}