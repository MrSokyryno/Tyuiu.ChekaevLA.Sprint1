using Tyuiu.ChekaevLA.Sprint1.Task0.V20.Lib;

namespace Tyuiu.ChekaevLA.Sprint1.Task0.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService testdata = new DataService();
            Assert.AreEqual(13, testdata.Calculate());
        }
    }
}
