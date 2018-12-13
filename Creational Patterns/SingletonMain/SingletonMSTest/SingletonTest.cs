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
            instance1.Counter++;
            Assert.AreEqual(instance1.Counter, instance2.Counter);
            instance2.Counter++;
            Assert.AreEqual(instance1.Counter, instance2.Counter);
        }

        [TestMethod]
        public void Logger2Test()
        {
            Logger2 instance1 = Logger2.GetInstance();
            Logger2 instance2 = Logger2.GetInstance();
            Assert.AreSame(instance1, instance2);
            instance1.Counter++;
            Assert.AreEqual(instance1.Counter, instance2.Counter);
            instance2.Counter++;
            Assert.AreEqual(instance1.Counter, instance2.Counter);
        }
    }
}
