using Tyuiu.ShindinDN.Sprint2.Task7.V8.Lib;

namespace Tyuiu.ShindinDN.Sprint2.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(1, 5);
            Assert.AreEqual(false, res);
        }
    }
}