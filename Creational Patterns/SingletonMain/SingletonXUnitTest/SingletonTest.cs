using Singleton;
using Xunit;

namespace SingletonXUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Logger1Test()
        {
            Logger1 instance1 = Logger1.GetInstance;
            Logger1 instance2 = Logger1.GetInstance;
            Assert.Same(instance1, instance1);
            instance1.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
            instance2.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
        }

        [Fact]
        public void Logger2Test()
        {
            Logger2 instance1 = Logger2.GetInstance();
            Logger2 instance2 = Logger2.GetInstance();
            Assert.Same(instance1, instance1);
            instance1.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
            instance2.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
        }

        [Fact]
        public void Logger3Test()
        {
            Logger3 instance1 = Logger3.GetInstance;
            Logger3 instance2 = Logger3.GetInstance;
            Assert.Same(instance1, instance1);
            instance1.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
            instance2.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
        }

        [Fact]
        public void Logger4Test()
        {
            Logger4 instance1 = Logger4.GetInstance;
            Logger4 instance2 = Logger4.GetInstance;
            Assert.Same(instance1, instance1);
            instance1.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
            instance2.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
        }

        [Fact]
        public void Logger5Test()
        {
            Logger5 instance1 = Logger5.GetInstance;
            Logger5 instance2 = Logger5.GetInstance;
            Assert.Same(instance1, instance1);
            instance1.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
            instance2.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
        }

        [Fact]
        public void Logger5bTest()
        {
            Logger5b instance1 = Logger5b.GetInstance;
            Logger5b instance2 = Logger5b.GetInstance;
            Assert.Same(instance1, instance1);
            instance1.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
            instance2.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
        }

        [Fact]
        public void Logger5cTest()
        {
            Logger5c instance1 = Logger5c.GetInstance;
            Logger5c instance2 = Logger5c.GetInstance;
            Assert.Same(instance1, instance1);
            instance1.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
            instance2.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
        }

        [Fact]
        public void Logger6Test()
        {
            Logger6 instance1 = Logger6.GetInstance;
            Logger6 instance2 = Logger6.GetInstance;
            Assert.Same(instance1, instance1);
            instance1.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
            instance2.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
        }

        [Fact]
        public void Logger7Test()
        {
            Logger7 instance1 = Logger7.GetInstance;
            Logger7 instance2 = Logger7.GetInstance;
            Assert.Same(instance1, instance1);
            instance1.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
            instance2.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
        }

        [Fact]
        public void GenericLoggerTest8()
        {
            FileLogger instance1 = GenericLogger<FileLogger>.GetInstance();
            FileLogger instance2 = GenericLogger<FileLogger>.GetInstance();
            Assert.Same(instance1, instance1);
            instance1.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
            instance2.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
        }

        [Fact]
        public void GenericLoggerTest9()
        {
            EventLogger instance1 = GenericLogger<EventLogger>.GetInstance();
            EventLogger instance2 = GenericLogger<EventLogger>.GetInstance();
            Assert.Same(instance1, instance1);
            instance1.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
            instance2.Counter++;
            Assert.Equal(instance1.Counter, instance2.Counter);
        }
    }
}
