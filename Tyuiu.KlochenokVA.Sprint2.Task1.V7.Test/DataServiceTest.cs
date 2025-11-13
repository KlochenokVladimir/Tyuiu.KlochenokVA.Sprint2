using Tyuiu.KlochenokVA.Sprint2.Task1.V7.Lib;

namespace Tyuiu.KlochenokVA.Sprint2.Task1.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 195, b = 16, c = 14, d = 45;
            bool[] expected = { true, false, false, false, true, false };
            bool[] actual = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
