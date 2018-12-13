using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;

namespace SingletonMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Logger1Test()
        {
            Logger1 instance1 = Logger1.GetInstance;
            Logger1 instance2 = Logger1.GetInstance;
            Assert.AreSame(instance1, instance2);

            instance1.counter++;
            Assert.AreEqual(instance1.counter, instance2.counter);

            instance2.counter++;
            Assert.AreEqual(instance1.counter, instance2.counter);

        }
    }
}
