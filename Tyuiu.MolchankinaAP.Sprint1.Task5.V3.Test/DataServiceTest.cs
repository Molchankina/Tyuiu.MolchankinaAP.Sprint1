using Tyuiu.MolchankinaAP.Sprint1.Task5.V3.Lib;
namespace Tyuiu.MolchankinaAP.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 2314155;
            int res = ds.Calculate(k);
            Assert.AreEqual(1, res);
        }
    }
}