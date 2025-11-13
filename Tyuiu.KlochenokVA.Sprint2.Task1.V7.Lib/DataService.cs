using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KlochenokVA.Sprint2.Task1.V7.Lib
{
    public class DataService
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) && (c < d);        // (195 > 16) && (14 < 45) = True
            res[1] = (a < b) && (c > d);        // (195 < 16) && (14 > 45) = False  
            res[2] = !(a > b);                  // !(195 > 16) = False
            res[3] = (b > c) ^ (d < a);         // (16 > 14) ^ (45 < 195) = False
            res[4] = (a >= b) && (c <= d);      // (195 >= 16) && (14 <= 45) = True
            res[5] = (a == b) | (c > d);        // (195 == 16) | (14 > 45) = False
            return res;
        }
    }
}
