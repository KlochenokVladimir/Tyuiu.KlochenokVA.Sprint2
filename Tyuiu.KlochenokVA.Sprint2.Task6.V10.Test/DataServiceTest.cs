using Tyuiu.KlochenokVA.Sprint2.Task6.V10.Lib;
namespace Tyuiu.KlochenokVA.Sprint2.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("13.10.2023", ds.FindDateOfPreviousDay(2023, 10, 14));
        }
    }
}
