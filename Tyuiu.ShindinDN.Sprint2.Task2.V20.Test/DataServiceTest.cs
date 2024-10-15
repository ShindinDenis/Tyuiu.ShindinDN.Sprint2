using Tyuiu.ShindinDN.Sprint2.Task2.V20.Lib;

namespace Tyuiu.ShindinDN.Sprint2.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 13; int y = 6;
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}