using Tyuiu.ChekaevLA.Sprint1.Task1.V20.Lib;

namespace Tyuiu.ChekaevLA.Sprint1.Task1.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 5;
            double b = 2;
            DataService dataService = new DataService();
            Assert.AreEqual(15.0, dataService.Calculate(a, b));
        }
    }
}
