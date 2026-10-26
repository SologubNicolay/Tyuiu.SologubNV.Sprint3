using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SologubNV.Sprint3.Task6.V16.Lib
{
    public class DataService : ISprint3Task6V16
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int c = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                    }
                }
            }
            return c;
        }
    }
}
