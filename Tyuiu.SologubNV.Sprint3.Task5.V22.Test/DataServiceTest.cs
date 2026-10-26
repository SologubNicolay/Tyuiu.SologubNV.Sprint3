using Tyuiu.SologubNV.Sprint3.Task5.V22.Lib;

namespace Tyuiu.SologubNV.Sprint3.Task5.V22.lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        int x = 2;
        int startv = 1;
        int endv = 3;
        int startv2 = 1;
        int endv2 = 12;
        double res = ds.GetSumSumSeries(x,startv,startv2,endv,endv2);
        double wait = 68.991;
        Assert.AreEqual(wait, res);
    }
}
