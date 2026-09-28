using Tyuiu.ChekaevLA.Sprint1.Task4.V18.Lib;

namespace Tyuiu.ChekaevLA.Sprint1.Task4.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            double x = 6;
            double y = 1;
            double res = 0.083;
            Assert.AreEqual(res, dataService.Calculate(x,y));
        }
    }
}
