using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SologubNV.Sprint3.Task6.V24.Lib
{
    public class DataService : ISprint3Task7V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueA = new double[len];
            double y;
            int c = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((x + 1.2) == 0)
                {
                    valueA[c] = 0;
                    c++;
                }
                else
                {
                    y = (Math.Sin(x) / (x + 1.2) - Math.Sin(x) * 2 - 2 * x);
                    valueA[c] = Math.Round(y,2);
                    c++;
                }
            }
            return valueA;
        }
    }
}
