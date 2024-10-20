using Tyuiu.MolchankinaAP.Sprint1.Task6.V12.Lib;
namespace Tyuiu.MolchankinaAP.Sprint1.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            bool result = ds.CheckLastWordRepetiton("Это тест тест");
            Assert.IsTrue(result);
        }
    }
}