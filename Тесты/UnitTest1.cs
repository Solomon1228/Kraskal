using Microsoft.VisualStudio.TestTools.UnitTesting;
using Лаба_9;
namespace Тесты
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Money a = new Money();
            Assert.IsTrue(a.Kopeks == 0 && a.Rubles == 0);
        }
    }
}
