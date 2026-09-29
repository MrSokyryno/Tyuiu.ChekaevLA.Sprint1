using Tyuiu.ChekaevLA.Sprint1.Task7.V25.Lib;

namespace Tyuiu.ChekaevLA.Sprint1.Task7.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double X = 5.0;
            double Y = 5.0;
            DataService dataService = new DataService();
            Assert.AreEqual(148.254, dataService.Calculate(X, Y));
        }
    }
}
