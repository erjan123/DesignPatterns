using NUnit.Framework;
using Singleton;

namespace Tests
{

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Logger1Test()
        {
            Logger1 instance1 = Logger1.GetInstance;
            Logger1 instance2 = Logger1.GetInstance;
            Assert.AreSame(instance1, instance2);
            instance1.counter++;
            Assert.AreEqual(instance1.counter, instance1.counter);
            instance2.counter++;
            Assert.AreEqual(instance1.counter, instance2.counter);
        }
    }
}