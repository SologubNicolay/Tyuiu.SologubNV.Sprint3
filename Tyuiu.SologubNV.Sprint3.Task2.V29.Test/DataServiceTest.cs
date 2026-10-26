using Tyuiu.SologubNV.Sprint3.Task2.V29.Lib;
namespace Tyuiu.SologubNV.Sprint3.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds= new DataService();
            int startv = 1;
            int endv = 18;
            double a = 0.5;
            double res = ds.GetSumSeries(a, startv, endv);
            double wait = -0.186;
            Assert.AreEqual(wait, res);
        }
    }
}
