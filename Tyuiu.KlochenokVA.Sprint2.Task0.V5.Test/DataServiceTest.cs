using Tyuiu.KlochenokVA.Sprint2.Task0.V5.Lib;

namespace Tyuiu.KlochenokVA.Sprint2.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 105, y = 223;
            bool[] expected = { false, true, true, true, false, true };
            bool[] actual = ds.GetCompareOperations(x, y);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
