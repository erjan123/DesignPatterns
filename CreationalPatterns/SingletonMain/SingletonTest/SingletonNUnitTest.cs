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
            Logger3 instance1 = Logger3.GetInstance;
            Logger3 instance2 = Logger3.GetInstance;
            Assert.AreSame(instance1, instance2);
            instance1.Counter++;
            Assert.AreEqual(instance1.Counter, instance1.Counter);
            instance2.Counter++;
            Assert.AreEqual(instance1.Counter, instance2.Counter);
        }

        [Test]
        public void Logger4Test()
        {
            Logger4 instance1 = Logger4.GetInstance;
            Logger4 instance2 = Logger4.GetInstance;
            Assert.AreSame(instance1, instance2);
            instance1.Counter++;
            Assert.AreEqual(instance1.Counter, instance1.Counter);
            instance2.Counter++;
            Assert.AreEqual(instance1.Counter, instance2.Counter);

        }

        [Test]
        public void Logger5Test()
        {
            Logger5 instance1 = Logger5.GetInstance;
            Logger5 instance2 = Logger5.GetInstance;
            Assert.AreSame(instance1, instance2);
            instance1.Counter++;
            Assert.AreEqual(instance1.Counter, instance1.Counter);
            instance2.Counter++;
            Assert.AreEqual(instance1.Counter, instance2.Counter);
        }

        [Test]
        public void Logger5bTest()
        {
            Logger5b instance1 = Logger5b.GetInstance;
            Logger5b instance2 = Logger5b.GetInstance;
            Assert.AreSame(instance1, instance2);
            instance1.Counter++;
            Assert.AreEqual(instance1.Counter, instance1.Counter);
            instance2.Counter++;
            Assert.AreEqual(instance1.Counter, instance2.Counter);
        }

        [Test]
        public void Logger5cTest()
        {
            Logger5c instance1 = Logger5c.GetInstance;
            Logger5c instance2 = Logger5c.GetInstance;
            Assert.AreSame(instance1, instance2);
            instance1.Counter++;
            Assert.AreEqual(instance1.Counter, instance1.Counter);
            instance2.Counter++;
            Assert.AreEqual(instance1.Counter, instance2.Counter);
        }

        [Test]
        public void Logger6Test()
        {
            Logger6 instance1 = Logger6.GetInstance;
            Logger6 instance2 = Logger6.GetInstance;
            Assert.AreSame(instance1, instance2);
            instance1.Counter++;
            Assert.AreEqual(instance1.Counter, instance1.Counter);
            instance2.Counter++;
            Assert.AreEqual(instance1.Counter, instance2.Counter);
        }

        [Test]
        public void Logger7Test()
        {
            Logger7 instance1 = Logger7.GetInstance;
            Logger7 instance2 = Logger7.GetInstance;
            Assert.AreSame(instance1, instance2);
            instance1.Counter++;
            Assert.AreEqual(instance1.Counter, instance1.Counter);
            instance2.Counter++;
            Assert.AreEqual(instance1.Counter, instance2.Counter);
        }

        [Test]
        public void GenericLoggerTest8()
        {
            FileLogger instance1 = GenericLogger<FileLogger>.GetInstance();
            FileLogger instance2 = GenericLogger<FileLogger>.GetInstance();
            Assert.AreSame(instance1, instance2);
            instance1.Counter++;
            Assert.AreEqual(instance1.Counter, instance1.Counter);
            instance2.Counter++;
            Assert.AreEqual(instance1.Counter, instance2.Counter);
        }

        [Test]
        public void GenericLoggerTest9()
        {
            EventLogger instance1 = GenericLogger<EventLogger>.GetInstance();
            EventLogger instance2 = GenericLogger<EventLogger>.GetInstance();
            Assert.AreSame(instance1, instance2);
            instance1.Counter++;
            Assert.AreEqual(instance1.Counter, instance1.Counter);
            instance2.Counter++;
            Assert.AreEqual(instance1.Counter, instance2.Counter);
        }

        [Test]
        public void BadAssSingleton10()
        {
            BadAssSingleton instance1 = BadAssSingleton.OnlyInstance;
            BadAssSingleton instance2 = BadAssSingleton.OnlyInstance;
            Assert.AreSame(instance1, instance2);
            instance1.Counter++;
            Assert.AreEqual(instance1.Counter, instance1.Counter);
            instance2.Counter++;
            Assert.AreEqual(instance1.Counter, instance2.Counter);
        }
    }
}