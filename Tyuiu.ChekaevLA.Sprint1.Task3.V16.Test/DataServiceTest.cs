using Tyuiu.ChekaevLA.Sprint1.Task3.V16.Lib;

namespace Tyuiu.ChekaevLA.Sprint1.Task3.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            double x1= 2.5;
            double x2= 4.6;
            Assert.AreEqual(-7.1, dataService.CoeffOfQuadraticEquation(x1,x2));
        }
    }
}
