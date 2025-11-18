using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KlochenokVA.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task6V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (n == 1)
            {
                if (m == 1)
                {
                    m = 12;
                    n = 31;
                    g--;
                }
                else
                {
                    m--;
                    n = m switch
                    {
                        1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                        2 => 28,
                        _ => 30
                    };
                }
            }
            else
            {
                n--;
            }

            
            return $"{n:00}.{m:00}.{g}";
        }
    }
}
