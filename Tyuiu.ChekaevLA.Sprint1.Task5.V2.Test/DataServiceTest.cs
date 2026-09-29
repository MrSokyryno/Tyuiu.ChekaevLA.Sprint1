using Tyuiu.ChekaevLA.Sprint1.Task5.V2.Lib;

namespace Tyuiu.ChekaevLA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int Fahr = 32;
            Assert.AreEqual(0, dataService.FahrenheitToСelsius(Fahr));
        }
    }
}
