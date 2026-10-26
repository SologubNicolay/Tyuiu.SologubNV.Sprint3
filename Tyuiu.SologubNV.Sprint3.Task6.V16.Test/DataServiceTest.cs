using Tyuiu.SologubNV.Sprint3.Task6.V16.Lib;
namespace Tyuiu.SologubNV.Sprint3.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startv = 5;
            int endv = 16;
            double res = ds.GetSumTheDivisors(startv, endv);
            double wait = 42;
            Assert.AreEqual(wait, res);
        }
    }
}
