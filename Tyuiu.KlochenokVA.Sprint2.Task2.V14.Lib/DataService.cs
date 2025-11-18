using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KlochenokVA.Sprint2.Task2.V14.Lib
{
    public class DataService : ISprint2Task2V14
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            int[] array1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] array2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 8, 8, 8, 0, 0 };
            int[] array3 = { 0, 0, 8, 8, 8, 0, 0, 0, 0, 8, 8, 8, 8, 0, 0 };
            int[] array4 = { 0, 8, 8, 8, 8, 0, 0, 0, 0, 8, 8, 8, 0, 0, 0 };
            int[] array5 = { 0, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 0, 0, 0 };
            int[] array6 = { 0, 0, 8, 8, 8, 8, 8, 8, 0, 0, 0, 0, 0, 0, 0 };
            int[] array7 = { 0, 0, 8, 8, 8, 8, 8, 8, 0, 0, 0, 0, 0, 0, 0 };
            int[] array8 = { 0, 0, 0, 0, 0, 8, 8, 8, 0, 0, 0, 0, 0, 0, 0 };
            int[] array9 = { 0, 0, 0, 0, 0, 8, 8, 8, 0, 0, 0, 0, 8, 0, 0 };
            int[] arrayq = { 0, 0, 0, 0, 0, 8, 8, 8, 0, 0, 0, 0, 8, 0, 0 };
            int[] arrayw = { 0, 0, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 0, 0 };
            int[] arraye = { 0, 0, 0, 0, 0, 0, 8, 8, 8, 8, 0, 0, 8, 0, 0 };
            int[] arrayr = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0 };
            int[] arrayt = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] arrayy = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            int[][] arrays = { array1, array2, array3, array4, array5, array6, array7, array8, array9, arrayq, arrayw, arraye, arrayr, arrayr, arrayy };

            if ((x > 0 && x < 16) && (y > 0 && y < 16))
            {
                if (arrays[y - 1][x - 1] == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
