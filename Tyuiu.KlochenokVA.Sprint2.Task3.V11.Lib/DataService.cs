using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KlochenokVA.Sprint2.Task3.V11.Lib
{
    public class DataService : ISprint2Task3V11
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 0)
            {
                y = x + Math.Pow((x - 15.0) / (x - 19.0), x);
            }
            else if (x == 0)
            {
                y = (x * x - Math.Cos(x * x) + 10) / (x * x - Math.Sin(x * x) + 12);
            }
            else if (x > -15 && x < 0)
            {
                y = Math.Pow(1 + 1.0 / (x * x), x);
            }
            else if (x < -15)
            {
                y = x + 10 * x - 1.0 / x;
            }

            return y;
        }
    }
}