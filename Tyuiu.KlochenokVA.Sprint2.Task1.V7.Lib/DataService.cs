using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KlochenokVA.Sprint2.Task1.V7.Lib
{
    public class DataService : ISprint2Task1V7
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c < d);
            res[1] = (a > b) & (c + 32 < d);
            res[2] = (a - 180 > b) || (c + 32 < d);
            res[3] = (a - 180 > b) && (c < d);
            res[4] = !(!res[0]);
            res[5] = (a > b) ^ (c < d);

            return res;
        }
    }
}
