using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SologubNV.Sprint3.Task1.V28.Lib
{
    public class DataService : ISprint3Task1V28
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            double x = 0.25;
            
            while (startValue <= stopValue) {
                sum += (Math.Pow(value, startValue)+x) * Math.Cos(startValue);
                startValue++;
            }
            return Math.Round(sum,3);
        }
    }
}
