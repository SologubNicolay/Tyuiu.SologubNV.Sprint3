using Tyuiu.SologubNV.Sprint3.Task4.V29.Lib;
namespace Tyuiu.SologubNV.Sprint3.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startv = -5;
            int endv = 5;
            double res = ds.Calculate(startv, endv);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}
