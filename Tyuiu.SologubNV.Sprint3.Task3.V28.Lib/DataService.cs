using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SologubNV.Sprint3.Task3.V28.Lib
{
    public class DataService : ISprint3Task3V28
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            foreach (char x in value)
            {
                if (char.IsDigit(x))
                {
                    value = value.Replace(x, item); 
                }
            }
            return value;
        }
    }
}
