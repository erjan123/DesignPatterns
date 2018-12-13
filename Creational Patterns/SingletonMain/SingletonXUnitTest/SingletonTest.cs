using System;
using Xunit;
using Singleton;

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
    }
}
