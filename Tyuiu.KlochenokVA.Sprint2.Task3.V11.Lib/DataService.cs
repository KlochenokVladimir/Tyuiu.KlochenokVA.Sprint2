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
                double temp = (x - 15.0) / (x - 19.0);
                y = x + Math.Pow(temp, x);
            }
            else if (x == 0)
            {
                double xx = x * x;
                y = (xx - Math.Cos(xx) + 10.0) / (xx - Math.Sin(xx) + 12.0);
            }
            else if (x > -15 && x < 0)
            {
                y = Math.Pow(1.0 + 1.0 / (x * x), x);  // ← Вот тут была ошибка: 1 вместо 1.0
            }
            else if (x < -15)
            {
                y = x + 10.0 * x - 1.0 / x;
            }

            return y;
        }
    }
}