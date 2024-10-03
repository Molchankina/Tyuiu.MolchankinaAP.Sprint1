using Tyuiu.MolchankinaAP.Sprint1.Task2.V5.Lib;
namespace Tyuiu.MolchankinaAP.Sprint1.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 5;
            var res = ds.CalculateSideSquare(x);
            Assert.AreEqual(25, res);
        }
    }
}