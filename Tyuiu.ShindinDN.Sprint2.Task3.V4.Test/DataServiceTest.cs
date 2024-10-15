using Tyuiu.ShindinDN.Sprint2.Task3.V4.Lib;

namespace Tyuiu.ShindinDN.Sprint2.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(5);
            Assert.AreEqual(12.594, res);
        }
    }
}