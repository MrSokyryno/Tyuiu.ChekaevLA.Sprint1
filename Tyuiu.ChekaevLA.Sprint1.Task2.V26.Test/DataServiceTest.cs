using Tyuiu.ChekaevLA.Sprint1.Task2.V26.Lib;

namespace Tyuiu.ChekaevLA.Sprint1.Task2.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int hours = 13;
            int minutes = 10;
            Assert.AreEqual(790, dataService.CalculateMinutesSinceStart(hours, minutes));
        }
    }
}
