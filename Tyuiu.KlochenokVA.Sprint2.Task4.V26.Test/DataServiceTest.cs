using Tyuiu.KlochenokVA.Sprint2.Task4.V26.Lib;
namespace Tyuiu.KlochenokVA.Sprint2.Task4.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x = 30, y = 5;
            var res = ds.Calculate(x, y);
            double wait = 900;
            Assert.AreEqual(wait, res);
        }
    }
}
