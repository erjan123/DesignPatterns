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
            instance1.Counter++;
            Assert.AreEqual(instance1.Counter, instance1.Counter);
            instance2.Counter++;
            Assert.AreEqual(instance1.Counter, instance2.Counter);
        }

        [Test]
        public void Logger2Test()
        {
            Logger2 instance1 = Logger2.GetInstance();
            Logger2 instance2 = Logger2.GetInstance();
            Assert.AreSame(instance1, instance2);
            instance1.Counter++;
            Assert.AreEqual(instance1.Counter, instance1.Counter);
            instance2.Counter++;
            Assert.AreEqual(instance1.Counter, instance2.Counter);
        }

        [Test]
        public void Logger3Test()
        {

        }

        [Test]
        public void Logger4Test()
        {

        }

        [Test]
        public void Logger5Test()
        {

        }

        [Test]
        public void Logger6Test()
        {

        }

        [Test]
        public void Logger7Test()
        {

        }
    }
}