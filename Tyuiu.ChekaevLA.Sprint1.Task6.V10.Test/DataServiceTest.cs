using Tyuiu.ChekaevLA.Sprint1.Task6.V10.Lib;

namespace Tyuiu.ChekaevLA.Sprint1.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual("Привет мр", dataService.DeleteMiddleLetter("Привет мир"));
        }
    }
}
