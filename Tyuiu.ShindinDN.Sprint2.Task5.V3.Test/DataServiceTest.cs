using Tyuiu.ShindinDN.Sprint2.Task5.V3.Lib;

namespace Tyuiu.ShindinDN.Sprint2.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 3;
            string res = ds.FindDayName(value);
            Assert.AreEqual("среда", res);
        }
    }
}