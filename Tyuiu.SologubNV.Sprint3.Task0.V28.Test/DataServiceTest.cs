using Tyuiu.SologubNV.Sprint3.Task0.V28.Lib;
namespace Tyuiu.SologubNV.Sprint3.Task0.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiSeries()
        {
            DataService ds = new DataService();
            double x = 0.25;
            int startv = 1;
            int endv = 17;
            double res = ds.GetMultiplySeries(x, startv, endv);
            double wait = 411589.537;
            Assert.AreEqual(wait, res);
        }
    }
}
