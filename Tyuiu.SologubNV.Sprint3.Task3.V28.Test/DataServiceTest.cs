using Tyuiu.SologubNV.Sprint3.Task3.V28.Lib;
namespace Tyuiu.SologubNV.Sprint3.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds=new DataService();
            char a = 'r';
            string value = "f35hyt t4j 3gkg45";
            string res = ds.ReplaceNumOnChar(value, a);
            string wait = "frrhyt trj rgkgrr";
            Assert.AreEqual(wait, res);
        }
    }
}
