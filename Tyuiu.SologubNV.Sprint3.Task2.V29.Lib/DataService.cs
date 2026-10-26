using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SologubNV.Sprint3.Task2.V29.Lib
{
    public class DataService : ISprint3Task2V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double Sum = 0;
            do
            {
                Sum += (Math.Pow(value, startValue) + 0.25) * Math.Cos(startValue);
                startValue++;
            } while(startValue <= stopValue);
            return Math.Round(Sum,3);
        }
    }
}
